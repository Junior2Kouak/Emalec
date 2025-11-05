using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmContratAutoST : Form
  {
    // feuille ouverte en création ou modification
    public string mstrStatutContrat;
    public int mNumContratST;
    public string msDatePlanif;
    public string msMontantDevis;
    public bool mbDesactive;
    public string mstrStatutAlerte;
    public string msTypeContrat;

    public bool mbFacture = false;

    string strStatutValidationCmd;
    bool bModif;
    int iclient;
    double dTaux;
    string sDevise;
    double dMttCStLoaded;

    double dTauxHor_Base;
    double dTauxDepl_Base;

    MozartUC.apiLabel[] tlblPer;
    MozartUC.apiLabel[] tlblSign;

    DataTable dtSth = new DataTable();
    DataTable dtstb = new DataTable();
    DataTable dtDoc = new DataTable();


    public frmContratAutoST() { InitializeComponent(); }

    private void frmContratAutoST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //initialisation des tableaux d'apilabel
        tlblPer = new apiLabel[] { lblPer0, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer6 };
        tlblSign = new apiLabel[] { lblSign0, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5, lblSign6 };

        cmdDate2.Visible = cmdDate1.Visible = cmdSupp1.Visible = cmdSupp2.Visible = lblPeriode.Visible = false;
        // init
        dTauxHor_Base = dTauxDepl_Base = 0;

        InitialiserFeuille();

        // on affiche les informations d'historique du stt
        apiTGridH.LoadData(dtSth, MozartDatabase.cnxMozart, $"api_sp_ContratEnCoursSTT {Utils.ZeroIfNull(txtFields12.Tag)},'{MozartParams.NomSociete}', 'E'");
        apiTGridH.GridControl.DataSource = dtSth;

        apiTGridB.LoadData(dtstb, MozartDatabase.cnxMozart, $"api_sp_ContratEnCoursSTT '{Utils.ZeroIfNull(txtFields12.Tag)}','{MozartParams.NomSociete}', 'H'");
        apiTGridB.GridControl.DataSource = dtstb;
        InitGrid();

        apiTGrid2.LoadData(dtDoc, MozartDatabase.cnxMozart, $"EXEC api_sp_StatutDocSTF 0,{Utils.ZeroIfNull(txtFields12.Tag)}");
        apiTGrid2.GridControl.DataSource = dtDoc;
        InitApiGridDoc();

        // gestion des contrats par période
        // affichage des champs spécifiques pour cette catégorie là.
        if (msTypeContrat == "D")
        {
          lblDateDebut.Text = "Date de début";
          lblDateFin.Visible = txtDateFin.Visible = cmdDate1.Visible = cmdSupp1.Visible = cmdDate2.Visible = cmdSupp2.Visible = lblPeriode.Visible = true;

          // calcul du total des factures Ravel sur ce contrat
          lblEncours.Visible = txtFactRecues.Visible = true;
          txtFactRecues.Text = MontantFacturesRavel(mNumContratST).ToString();

          // uniquement si droit sur neutralisation CS
          if (ModuleMain.RechercheDroitMenu(673))
          {
            chkEncours.Visible = true;
          }
          // pour les contrats périodiques, il faut un forfait obligatoirement
          // donc on cache le choix du détail
          optCout1.Checked = true;
          optCoutALL_Click(optCout1, null);
          optCout1.Visible = lblLabels2.Visible = optCout0.Visible = lblLabels0.Visible = lblLabels5.Visible = false;

        }
        if (mstrStatutContrat == "C")
        {
          // on est en création et on reprend le montant du devis ST qui est sur l'action
          if (msMontantDevis != "")
          {
            optCout1.Checked = true;
            optCoutALL_Click(optCout1, null);
            txtFor.Text = Strings.Format(Convert.ToDouble(msMontantDevis));
            if (dTaux != 0) txtForEtr.Text = Strings.Format(Convert.ToDouble(txtFor.Text) * dTaux, "# ##0.00");
          }
          msMontantDevis = "";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        //si il y a des modifications
        if (bModif)
        {
          DialogResult res = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
          if (DialogResult.Cancel == res) return;
          if (DialogResult.Yes == res) EnregistrerContratST();
        }
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // on teste si le stt est interdit
        if (STFGRPInterdit(Convert.ToInt32(txtFields2.Tag)))
        {
          MessageBox.Show(Resources.msg_sousTraitInterdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si la DI est facturée on ne peut pas créer de contrat
        //  If frmListeContratsST.bFacture Then
        if (mbFacture)
        {
          MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtRem.Text == "")
        {
          MessageBox.Show(Resources.msg_Entrez_action_dans_zone_presta, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtDelais.Text == "")
        {
          MessageBox.Show(Resources.msg_saisieDateExeObligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtDateFin.Text == "" && txtDateFin.Visible)
        {
          MessageBox.Show("Saisie de la date de fin obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // test de compatibilité des dates début et fin pour les contrats périodiques
        if (txtDateFin.Visible && (Convert.ToDateTime(txtDateFin.Text) < Convert.ToDateTime(txtDelais.Text)))
        {
          MessageBox.Show("La date de fin doit être supérieur à la date de début !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  pour les contrat périodique, il faut un forfait > 0
        if (msTypeContrat == "D" && Convert.ToDouble(txtFor.Text) == 0)
        {
          MessageBox.Show("Il faut un montant de forfait supérieur à 0 pour un contrat périodique", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (FrameLibChantierSTT.Visible && cboLibChantierSTT.Text == "")
        {
          MessageBox.Show(Resources.msg_selectLibelleSousTrait, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        //  test si prix unitaire > 0
        if (optCout0.Checked)
        {
          if (Convert.ToDouble(txtTaux.Text) == 0)
          {
            MessageBox.Show("Vous ne pouvez pas passer un contrat sans le prix unitaire de main d'oeuvre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        //  message si modification d'une commande déjà validée ou en cours de validation (E,V,I)
        if (strStatutValidationCmd != "P" && mstrStatutContrat == "M")
        {
          if (MessageBox.Show("Attention, si vous réenregistrez ce contrat, les validations hiérarchiques seront supprimées", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }
        //  test si autre contrat sur cette DI pour ce STT
        int iContrat = (int)MozartDatabase.ExecuteScalarInt($"exec api_sp_RechercheContratDI {Convert.ToInt32(txtFields13.Tag)},{MozartParams.NumAction},{MozartParams.NumDi}");
        if (iContrat > 0)
        {
          string strMessage = $"Vous souhaitez créer un contrat pour le sous traitant {txtFields12.Text}{Environment.NewLine}" +
                              $"Au moins un autre contrat de STT a déjà été fait pour ce STT.{Environment.NewLine}" +
                              $"Vérifier que le contrat que vous êtes en train de créer ne fait pas double emploi.{Environment.NewLine}" +
                              $"Si vous souhaitez modifier un contrat existant, annuler le premier contrat et informer le STT par courrier RAR avant de créer le nouveau contrat.{Environment.NewLine}" +
                              $"Souhaitez-vous confirmer la création de ce nouveau contrat ?{Environment.NewLine}";
          if (MessageBox.Show(strMessage, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }
        // on teste son taux de depandance
        // test taux de dependance, si taux de dependance => 30 % alors message + exit
        if (ModuleMain.IsOKTauxDependanceSTF(Convert.ToInt32(txtFields12.Tag), MozartParams.NumAction, MozartParams.UID, MozartParams.NomSociete) == false) return;
        //  si contrat périodique, test de facture Ravel.
        //  modification impossible sauf par droit spécifique si facture ravel existe sur le contrat
        if (mNumContratST != 0 && msTypeContrat == "D")
        {
          string sSQL = $"SELECT count(NFOUFACNUM) FROM TFOUFACCDE WHERE TFOUFACCDE.NCDENUM = {mNumContratST} AND TFOUFACCDE.VTYPECDE = 'CS'";
          int i = (int)MozartDatabase.ExecuteScalarInt(sSQL);
          if (i > 0)
          {
            if (ModuleMain.RechercheDroitMenu(674))
            {
              if (MessageBox.Show("La facture de ce contrat a été saisie dans Ravel.Voulez-vous quand même le modifier", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              MessageBox.Show("La facture de ce contrat a été saisie dans Ravel.Vous ne pouvez plus le modifier", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
        }

        // test si contrat > 1000 euros, alors on affiche le champ observations (FG le 19/11/20 passage de 3000 à 1000)
        if ((Convert.ToDouble(txtFor.Text) > 1000 && optCout1.Checked) && (mNumContratST == 0 || dMttCStLoaded != Convert.ToDouble(txtFor.Text)))
        {
          string strmessageObs = $"{Resources.txt_budgetChiffreDevisClient} : ... {Resources.txt_euroHT}{Environment.NewLine}" +
              $"- {Resources.txt_MontantDiffPropositionRecues} :{Environment.NewLine}" +
              $"- {Resources.col_Societe} ... : ... {Resources.txt_euroHT}, {Resources.txt_negocieA} ... {Resources.txt_euroHT}{Environment.NewLine}" +
              $"- {Resources.col_Societe} ... : ... {Resources.txt_euroHT}, {Resources.txt_negocieA} ... {Resources.txt_euroHT}{Environment.NewLine}" +
              $"- {Resources.col_Societe} ... : ... {Resources.txt_euroHT}, {Resources.txt_negocieA} ... {Resources.txt_euroHT}";

          frmObservationsAdd lFrmObsAdd = new frmObservationsAdd()
          {
            msObsAdd = strmessageObs
          };
          lFrmObsAdd.ShowDialog();
          if (lFrmObsAdd.msObsAdd != "")
          {
            txtRmEng.Text = lFrmObsAdd.msObsAdd + Environment.NewLine + txtRmEng.Text;
          }
        }

        EnregistrerContratST();

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (mNumContratST == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      //test si ST est un ST avec Accès Web
      if (ModuleMain.TestIfSTWithAccessWEB("CST", mNumContratST))
      {
        if (MessageBox.Show(Resources.msg_Warning_impr_doc_non_obligatoire_ST_a_acces_web, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
      }

      launchReport(true);

      // traitement MEDIAPOST cotraitant
      // TB SAMSIC CITY SPEC
      // on regarde si le STT est un cotraitant impose car alors il faut utiliser un modèle spécifique.
      if (!(iclient == 12015 && MozartParams.NomGroupe == "EMALEC" && IsCotraitantImpose()))
      {
        //  s'il existe une planification préventif, rechercher la gamme
        int iG = MozartDatabase.ExecuteScalarInt($"select count(NIPLSTNUM) from TIPLST WHERE NACTNUM = {MozartParams.NumAction}");

        if (iG > 0)
        {
          // recherche de la gamme sur l'action
          using (SqlDataReader sdrA = MozartDatabase.ExecuteReader($"SELECT NGAMNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NACTNUM = {MozartParams.NumAction}"))
          {
            if (sdrA.Read())
              Utils.ImpressionGammeST((long)Utils.ZeroIfNull(sdrA["NGAMNUM"]), txtLangue.Text);
          }
        }
      }
    }

    // pForPrinting = TRUE pour PRINT, FALSE pour PREVIEW
    private void launchReport(bool pForPrinting)
    {
      // traitement specifique pour Mediapost
      // on regarde si le STT est un cotraitant impose car alors il faut utiliser un modèle spécifique
      string lTypeReport;
      if (iclient == 12015 && MozartParams.NomGroupe == "EMALEC" && IsCotraitantImpose())
      {
        // case spécial Mediapost
        lTypeReport = "TContratSousTraitanceMediapost";
      }
      else
      {
        //  cas général
        lTypeReport = "TContratSousTraitance";
      }

      string lOption = pForPrinting ? "PRINT" : "PREVIEW";

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = lTypeReport,
        sIdentifiant = $"{MozartParams.NumAction}|{mNumContratST}",
        InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = txtLangue.Text,
        sOption = lOption,
        strType = "CS",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (mNumContratST == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Cursor = Cursors.WaitCursor;
      launchReport(false);
      Cursor = Cursors.Default;
    }

    private void cmdAttach_Click(object sender, EventArgs e)
    {
      if (mNumContratST == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TAttachementContrat",
        sIdentifiant = $"{MozartParams.NumAction}|{mNumContratST}",
        InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = txtLangue.Text,
        sOption = "PREVIEW",
        strType = "CS",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

      private void cmdGamme_Click(object sender, EventArgs e)
    {
      if (mNumContratST == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      // s'il existe un planification préventif, rechercher la gamme
      if ((int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(NIPLSTNUM) FROM TIPLST WHERE NACTNUM = {MozartParams.NumAction}") > 0)
      {
        //recherche de la gamme sur l'action
        using (SqlDataReader sdrA = MozartDatabase.ExecuteReader($"SELECT NGAMNUM FROM TACT WITH (NOLOCK) WHERE NGAMNUM <> 0 AND NACTNUM = {MozartParams.NumAction}"))
        {
          if (sdrA.Read())
          {
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = "TGAMMECLIENTST",
              sIdentifiant = $"{sdrA["NGAMNUM"]}|{MozartParams.NumAction}",
              InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
              sNomSociete = MozartParams.NomSociete,
              sLangue = MozartParams.Langue,
              sOption = "PREVIEW"
            }.ShowDialog();

          }
        }
      }
    }

    private void cmdAlert_Click(object sender, EventArgs e)
    {
      if (mstrStatutAlerte == "C") return;

      new frmSaisieAlertRavel()
      {
        mstrType = "SOUS-TRAITANT",
        miNumObjet = mNumContratST
      }.ShowDialog();
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtFields10.Text);
            if (txtFields10.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields10.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
  
    private async void ApiTelAuto2_Click(object sender, EventArgs e)
    {
      //ApiTelAuto2.TelDial(txtFields14.Text);
            if (txtFields14.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields14.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto3_Click(object sender, EventArgs e)
    {
      //ApiTelAuto3.TelDial(txtFields5.Text);
            if (txtFields5.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields5.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void cmdSupp2_Click(object sender, EventArgs e)
    {
      txtDateFin.Text = "";
      lblPeriode.Text = "";
      bModif = true;
    }

    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDelais.Text = "";
      lblPeriode.Text = "";
      bModif = true;
    }

    private void frmContratAutoST_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDelais.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateFin.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDelais.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateFin.Text = Calendar1.Value.ToShortDateString();

      // delai des dates
      if (txtDateFin.Visible == true)
      {
        lblPeriode.Text = "sur " + Convert.ToString(((Convert.ToDateTime(txtDateFin.Text).Year - Convert.ToDateTime(txtDelais.Text).Year) * 12) + Convert.ToDateTime(txtDateFin.Text).Month - Convert.ToDateTime(txtDelais.Text).Month + 1) + " mois";
      }
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void EnregistrerContratST()
    {
      try
      {
        double dbFor = 0;
        double dTauxEnreg = 0;
        double dbDep = 0;

        // pour la création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_creationContratST", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iContrat"].Value = mNumContratST;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@tRem"].Value = ModuleMain.ReplaceCharToBD(txtRem.Text, "RTF");

          if (txtDelais.Text == "")
            cmd.Parameters["@dDelai"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDelai"].Value = Convert.ToDateTime(txtDelais.Text);

          if (txtDateFin.Text == "")
            cmd.Parameters["@dDateFin"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDateFin"].Value = Convert.ToDateTime(txtDateFin.Text);

          if (dTaux != 0)
          {
            dbFor = Convert.ToDouble(txtForEtr.Text) / dTaux;
            dTauxEnreg = Convert.ToDouble(txtTaux.Text) / dTaux;
            dbDep = Convert.ToDouble(txtDeplEtr.Text) / dTaux;
          }
          else
          {
            dbFor = Convert.ToDouble(txtFor.Text);
            dTauxEnreg = Convert.ToDouble(txtTaux.Text);
            dbDep = Convert.ToDouble(txtDepl.Text);
          }
          cmd.Parameters["@iNFor"].Value = dbFor;
          cmd.Parameters["@iNTaux"].Value = dTauxEnreg;
          cmd.Parameters["@iNDepl"].Value = dbDep;

          cmd.Parameters["@iContact"].Value = txtFields13.Tag;

          if (FrameLibChantierSTT.Visible)
            cmd.Parameters["@nidstt"].Value = cboLibChantierSTT.SelectedValue;
          else
            cmd.Parameters["@nidstt"].Value = DBNull.Value;

          cmd.Parameters["@iNForEtr"].Value = Utils.ZeroIfNull(txtForEtr.Text);
          cmd.Parameters["@iNTauxEtr"].Value = Utils.ZeroIfNull(txtTauxEtr.Text);
          cmd.Parameters["@iNDeplEtr"].Value = Utils.ZeroIfNull(txtDeplEtr.Text);
          cmd.Parameters["@cType"].Value = msTypeContrat;

          if (chkLocal.Checked)
            cmd.Parameters["@cLieu"].Value = "O";
          else
            cmd.Parameters["@cLieu"].Value = "N";

          if (chkEncours.Checked)
            cmd.Parameters["@cEncours"].Value = "O";
          else
            cmd.Parameters["@cEncours"].Value = "N";

          cmd.ExecuteNonQuery();

          mNumContratST = (int)cmd.Parameters[0].Value;
        }

        //  desactivation des autres contrats de l'action si necessaire
        if (mbDesactive)
          DesactiverContratAction();

        // traitement de la delegation
        TraitementDelegation(mNumContratST);

        //  passage en modification
        mstrStatutContrat = "M";

        //  mise a jour de l'affichage
        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void DesactiverContratAction()
    {
      try
      {
        // recherche des contrats de l'action sauf celui que l'on vient de creer
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"select NCSTNUM FROM TCST WHERE NCSTNUM<> {mNumContratST} AND NACTNUM= {MozartParams.NumAction}"))
        {
          while (sdr.Read())
          {
            // si on est en modification ou en création
            ModuleData.SupprimerEnreg((int)Utils.ZeroIfNull(sdr["NCSTNUM"]), "api_sp_SupprimerContratST", "@iNumContratST");
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      try
      {
        // recherche des infos du contrat
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourInfoContratST {mNumContratST},{MozartParams.NumAction},'{MozartParams.NomSociete}'"))
        {
          if (sdr.Read())
          {
            txtFields4.Text = Utils.BlankIfNull(sdr["NCSTNUM"]);
            txtFields3.Text = Utils.DateBlankIfNull(sdr["DCSTDAT"]);
            txtFields0.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtFields2.Text = Utils.BlankIfNull(sdr["NSITNUE"]);
            txtFields1.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
            txtFields6.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
            txtFields7.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
            txtFields9.Text = Utils.BlankIfNull(sdr["VSITVIL"]);
            txtFields8.Text = Utils.BlankIfNull(sdr["VSITCP"]);
            txtFields10.Text = Utils.BlankIfNull(sdr["VSITTEL"]);
            txtFields11.Text = Utils.BlankIfNull(sdr["VSITFAX"]);
            txtFields12.Text = Utils.BlankIfNull(sdr["VSTFNOM"]);
            txtFields13.Text = Utils.BlankIfNull(sdr["VINTNOM"]);
            txtFields14.Text = Utils.BlankIfNull(sdr["VINTTEL"]);
            txtFields15.Text = Utils.BlankIfNull(sdr["VINTFAX"]);
            txtFields17.Text = Utils.BlankIfNull(sdr["VSTFPAYS"]);
            txtFields5.Text = Utils.BlankIfNull(sdr["VINTPOR"]);
            msMontantDevis = Utils.BlankIfNull(sdr["NACTVALDEVST"]);

            // id sous-traitant et contact
            txtFields12.Tag = Utils.ZeroIfNull(sdr["NSTFNUM"]);
            txtFields13.Tag = Utils.ZeroIfNull(sdr["NINTNUM"]);
            iclient = (int)Utils.ZeroIfNull(sdr["NCLINUM"]);

            dTaux = Utils.ZeroIfNull(sdr["NTAUX"]);
            sDevise = Utils.BlankIfNull(sdr["VDEVISE"]);
            txtLangue.Text = Utils.BlankIfNull(sdr["VLANGUEABR"]);
            chkLocal.Checked = Utils.BlankIfNull(sdr["CCSTAUSIEGE"]) == "O" ? true : false;
            chkEncours.Checked = Utils.BlankIfNull(sdr["CCSTSENCOURS"]) == "O" ? true : false;

            Lbl_Etat_PPS.Text = Utils.BlankIfNull(sdr["NACTPPS"]);

            // si on est en modification ou en création
            if (sdr["NCSTNUM"].ToString() == "0")
            {
              mstrStatutContrat = "C";
              mNumContratST = 0;
              txtRem.Text = Utils.BlankIfNull(sdr["VACTDES"]);
              txtDelais.Text = msDatePlanif;

              if (Convert.ToInt32(sdr["CHANTIER"]) != 0)
              {
                FrameLibChantierSTT.Visible = true;

                if (MozartParams.NomSociete == "EMALECMPM")
                {
                  // On charge la combo des libellés fiche chantier
                  ModuleData.RemplirCombo(cboLibChantierSTT, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE NCANNUM = {sdr["NDINCTE"]} AND VTYPE = 'S' AND VSOCIETE = APP_NAME() AND TCHANTIERFICHE.NIDANACHAFICTYPE <> 4 ORDER BY TCHANTIERFICHE.NCLASS ", true);
                }
                else
                {
                  // On charge la combo des libellés fiche chantier
                  ModuleData.RemplirCombo(cboLibChantierSTT, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE NCANNUM = {sdr["NDINCTE"]} AND VTYPE = 'S' AND VSOCIETE = APP_NAME() ORDER BY TCHANTIERFICHE.NCLASS  ", true);
                }
                cboLibChantierSTT.ValueMember = "NIDFICHE";
                cboLibChantierSTT.DisplayMember = "VLIB";
              }

              // les champs modifiables
              //txtFor.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTFOR"]), "# ##0.00");
              txtFor.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTFOR"]));
              txtTaux.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTHTH"]), "# ##0.00");
              dTauxHor_Base = Utils.ZeroIfNull(sdr["NCSTHTH"]);
              txtDepl.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTDEP"]), "# ##0.00");
              dTauxDepl_Base = Utils.ZeroIfNull(sdr["NCSTDEP"]);

              if (dTaux != 0)
              {
                txtForEtr.Text = txtFor.Text;
                txtTauxEtr.Text = txtTaux.Text;
                txtDeplEtr.Text = txtDepl.Text;
              }
              else
              {
                txtForEtr.Text = "0";
                txtTauxEtr.Text = "0";
                txtDeplEtr.Text = "0";
              }
              dMttCStLoaded = 0;
            }
            else
            {
              mstrStatutContrat = "M";
              mNumContratST = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(sdr["NCSTNUM"]), 3));
              txtRem.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["TCSTPRE"]), "RTF");
              txtDelais.Text = Utils.DateBlankIfNull(sdr["DCSTDEL"], "dd/MM/yyyy");
              txtDateFin.Text = Utils.DateBlankIfNull(sdr["DCSTFIN"], "dd/MM/yyyy");
              if (txtDateFin.Text != "" && txtDelais.Text != "")
              {
                lblPeriode.Text = "sur " + Convert.ToString(((Convert.ToDateTime(txtDateFin.Text).Year - Convert.ToDateTime(txtDelais.Text).Year) * 12) + Convert.ToDateTime(txtDateFin.Text).Month - Convert.ToDateTime(txtDelais.Text).Month + 1) + " mois";
              }
              else
              {
                lblPeriode.Text = "";
              }
              if (Convert.ToInt32(sdr["CHANTIER"]) != 0)
              {
                FrameLibChantierSTT.Visible = true;
                // on charge la combo des libellés fiche chantier
                ModuleData.RemplirCombo(cboLibChantierSTT, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE NCANNUM = {sdr["NDINCTE"]} AND VTYPE = 'S' AND VSOCIETE = APP_NAME() ORDER BY VLIB ", true);
                cboLibChantierSTT.ValueMember = "NIDFICHE";
                cboLibChantierSTT.DisplayMember = "VLIB";
                cboLibChantierSTT.SelectedValue = Utils.BlankIfNull(sdr["NIDSTT"]);
              }

              // les champs modifiables
              //txtFor.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTFOR"]), "# ##0.00");
              txtFor.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTFOR"]));
              txtTaux.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTHTH"]), "# ##0.00");
              dTauxHor_Base = Utils.ZeroIfNull(sdr["NCSTHTH"]);
              txtDepl.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTDEP"]), "# ##0.00");
              dTauxDepl_Base = Utils.ZeroIfNull(sdr["NCSTDEP"]);
              txtForEtr.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTFORETR"]), "# ##0.00");
              txtTauxEtr.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTTHTHETR"]), "# ##0.00");
              txtDeplEtr.Text = Strings.Format(Utils.ZeroIfNull(sdr["NCSTDEPETR"]), "# ##0.00");

              dMttCStLoaded = Utils.ZeroIfNull(sdr["NCSTFOR"]);
            }

            // COULEUR DU BOUTON ALERT : jaune si une alerte a ete saisie
            if (sdr["VCSTALERT"].ToString() != "N" && sdr["VCSTALERT"].ToString() != "") cmdAlert.BackColor = MozartColors.ColorH80FFFF;
            // gestion du type forfait ou cout horaire
            if (Utils.ZeroIfNull(txtFor.Text) == 0)
            {
              optCout0.Checked = true;
              optCoutALL_Click(optCout0, null);
            }
            else
            {
              optCout1.Checked = true;
              optCoutALL_Click(optCout1, null);
            }
            // pas encore de modification
            bModif = false;
            // traitement delegation
            strStatutValidationCmd = Utils.BlankIfNull(sdr["CCSTVALID"]);
            AfficheDelegation(mNumContratST);
          }
        }
        // on désactive le bouton de validation si on vient de l'alerte pour éviter les ambiguités de validation
        // recherche des infos du contrat
        cmdValider.Enabled = !(mstrStatutAlerte == "OUI");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void optCoutALL_Click(object sender, EventArgs e)
    {
      try
      {
        int index = Convert.ToInt32(((RadioButton)sender).Tag);

        if (index == 0)
        {
          lblForfait.Visible = lbleForfait.Visible = txtDepl.Visible = lblTaux.Visible = lbleTaux.Visible = txtTaux.Visible = true;
          txtTaux.Text = dTauxHor_Base.ToString("# ##0.00");
          txtDepl.Text = dTauxDepl_Base.ToString("# ##0.00");

          lblFor.Visible = lbleFor.Visible = txtFor.Visible = false;
          txtFor.Text = "0";

          if (dTaux != 0)
          {
            txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = true;
            lbleTauxEtr.Text = $"{sDevise} HT de l'heure";
            lbleForfaitEtr.Text = $"{sDevise} HT forfaitaire";
            txtTaux.Enabled = txtDepl.Enabled = txtForEtr.Enabled = lblDeviseEtr.Visible = txtForEtr.Visible = false;
          }
          else
          {
            txtFor.Enabled = true;
            txtForEtr.Visible = lblDeviseEtr.Visible = txtTauxEtr.Visible = lbleTauxEtr.Visible = lbleForfaitEtr.Visible = false;
            //  gestion de droit de modif sur taux dep et horaire d'un stf, demande par mail de PC le 31/12/2018
            txtDepl.Enabled = txtTaux.Enabled = ModuleMain.RechercheDroitMenu(621);
          }
        }
        else
        {
          dTauxHor_Base = Convert.ToDouble(txtTaux.Text);
          dTauxDepl_Base = Convert.ToDouble(txtDepl.Text);

          lblForfait.Visible = lbleForfait.Visible = txtDepl.Visible = false;
          txtDepl.Text = "0,00";

          lblTaux.Visible = lbleTaux.Visible = txtTaux.Visible = false;
          txtTaux.Text = "0,00";

          lblFor.Visible = lbleFor.Visible = txtFor.Visible = true;

          if (dTaux != 0)
          {
            txtFor.Enabled = txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = false;
            txtForEtr.Visible = lblDeviseEtr.Visible = true;
            lblDeviseEtr.Text = $"{sDevise} HT";
            txtForEtr.Enabled = true;
          }
          else
          {
            txtFor.Enabled = true;
            txtForEtr.Visible = lblDeviseEtr.Visible = txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = false;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    /*private void optCoutALL_CheckedChanged(object sender, EventArgs e)
    {
      //  gestion de droit de modif sur taux dep et horaire d'un stf, demande par mail de PC le 31/12/2018
      bool droitModif = ModuleMain.RechercheDroitMenu(MozartParams.UID, 621);

      try
      {
        int index = Convert.ToInt32(((RadioButton)sender).Tag);

        if(index == 0){
          lblForfait.Visible = lbleForfait.Visible = txtDepl.Visible = lblTaux.Visible = lbleTaux.Visible = txtTaux.Visible = true;
          txtTaux.Text = dTauxHor_Base.ToString("# ##0.00");
          txtDepl.Text = dTauxDepl_Base.ToString("# ##0.00");

          lblFor.Visible = lbleFor.Visible = txtFor.Visible = false;
          txtFor.Text = "0,00";

          if (dTaux != 0)
          {
            txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = true;
            lbleTauxEtr.Text = $"{sDevise} HT de l'heure";
            lbleForfaitEtr.Text = $"{sDevise} HT forfaitaire";
            txtTaux.Enabled = txtDepl.Enabled = txtForEtr.Enabled = lblDeviseEtr.Visible = false;
          }
          else
          {
            txtFor.Enabled = true;
            txtForEtr.Visible = lblDeviseEtr.Visible = txtTauxEtr.Visible = lbleTauxEtr.Visible = lbleForfaitEtr.Visible = false;
            if (droitModif) txtTaux.Enabled = true;
            else txtTaux.Enabled = false;
            if (droitModif) txtDepl.Enabled = true;
            else txtDepl.Enabled = false;
          }
        }
        else{
          lblForfait.Visible = lbleForfait.Visible = txtDepl.Visible = false;
          txtDepl.Text = "0,00";

          dTauxHor_Base = Convert.ToDouble(txtTaux.Text);
          dTauxDepl_Base = Convert.ToDouble(txtDepl.Text);

          lblTaux.Visible = lbleTaux.Visible = txtTaux.Visible = false;
          txtTaux.Text = "0,00";

          lblFor.Visible = lbleFor.Visible = txtFor.Visible = true;
  
          if(dTaux != 0){
            txtFor.Enabled = txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = false;
            txtForEtr.Visible = lblDeviseEtr.Visible = true;
            lblDeviseEtr.Text = $"{sDevise} HT";

          }
          else{
            txtFor.Enabled = true;
            txtForEtr.Visible = lblDeviseEtr.Visible = txtTauxEtr.Visible = lbleTauxEtr.Visible = txtDeplEtr.Visible = lbleForfaitEtr.Visible = false;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }*/
    //Private Sub optCout_Click(index As Integer)
    //
    //  'gestion de droit de modif sur taux dep et horaire d'un stf, demande par mail de PC le 31/12/2018
    //  Dim bDroitModif As Boolean
    //  bDroitModif = RechercheDroitMenu(gintUID, 621)
    //
    //On Error GoTo handler
    //
    //  If index = 0 Then
    //    Me.lblForfait.Visible = True
    //    Me.lbleForfait.Visible = True
    //    Me.txtDepl.Visible = True
    //    
    //    Me.lblTaux.Visible = True
    //    Me.lbleTaux.Visible = True
    //    Me.txtTaux.Visible = True
    //    
    //    txtTaux.Text = nTauxHor_Base
    //    txtDepl.Text = nTauxDepl_Base
    //    
    //    Me.lblFor.Visible = False
    //    Me.lbleFor.Visible = False
    //    Me.txtFor.Visible = False
    //    Me.txtFor = "0"
    //    
    //    If dbTaux <> 0 Then
    //      txtTauxEtr.Visible = True
    //      lbleTauxEtr.Visible = True
    //      txtDeplEtr.Visible = True
    //      lbleTauxEtr.Caption = sDevise & " HT de l'heure"
    //      lbleForfaitEtr.Visible = True
    //      lbleForfaitEtr.Caption = sDevise & " HT forfaitaire"
    //      txtTaux.Enabled = False
    //      txtDepl.Enabled = False
    //      txtForEtr.Visible = False
    //      lblDeviseEtr.Visible = False
    //    Else
    //      txtFor.Enabled = True
    //      txtForEtr.Visible = False
    //      lblDeviseEtr.Visible = False
    //      txtTauxEtr.Visible = False
    //      lbleTauxEtr.Visible = False
    //      txtDeplEtr.Visible = False
    //      lbleForfaitEtr.Visible = False
    //        If bDroitModif = True Then txtTaux.Enabled = True Else txtTaux.Enabled = False
    //        If bDroitModif = True Then txtDepl.Enabled = True Else txtDepl.Enabled = False
    //    End If
    //    
    //  Else
    //    Me.lblForfait.Visible = False
    //    Me.lbleForfait.Visible = False
    //    Me.txtDepl.Visible = False
    //    Me.txtDepl = "0"
    //    
    //    nTauxHor_Base = CDbl(txtTaux.Text)
    //    nTauxDepl_Base = CDbl(txtDepl.Text)
    //    
    //    Me.lblTaux.Visible = False
    //    Me.lbleTaux.Visible = False
    //    Me.txtTaux.Visible = False
    //    Me.txtTaux = "0"
    //
    //    Me.lblFor.Visible = True
    //    Me.lbleFor.Visible = True
    //    Me.txtFor.Visible = True
    //      
    //    If dbTaux <> 0 Then
    //      txtFor.Enabled = False
    //      txtForEtr.Visible = True
    //      lblDeviseEtr.Visible = True
    //      lblDeviseEtr.Caption = sDevise & " HT"
    //      txtTauxEtr.Visible = False
    //      lbleTauxEtr.Visible = False
    //      txtDeplEtr.Visible = False
    //      lbleForfaitEtr.Visible = False
    //    Else
    //      txtFor.Enabled = True
    //      txtForEtr.Visible = False
    //      lblDeviseEtr.Visible = False
    //      txtTauxEtr.Visible = False
    //      lbleTauxEtr.Visible = False
    //      txtDeplEtr.Visible = False
    //      lbleForfaitEtr.Visible = False
    //    End If
    //    
    //  End If
    //        
    //Exit Sub
    //handler:
    //  ShowError "optCout_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtALL_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
      bModif = true;
    }

    private bool IsCotraitantImpose()
    {
      // test dans la table des filiales
      string sSQL = $"SELECT count(TCONT.VSTIMPOSE) FROM dbo.TACT INNER JOIN dbo.TDIN ON dbo.TACT.NDINNUM = dbo.TDIN.NDINNUM INNER JOIN " +
          $"dbo.TCONT ON dbo.TACT.NSITNUM = dbo.TCONT.NSITNUM AND dbo.TCONT.NINTNUM = dbo.TACT.NINTNUM " +
          $" And dbo.TDIN.NTYPECONTRAT = dbo.TCONT.NTYPECONTRAT where TCONT.VSTIMPOSE='OUI' AND NACTNUM = {MozartParams.NumAction}";

      if ((int)MozartDatabase.ExecuteScalarInt(sSQL) > 0) return true;

      return false;
    }

    public void TraitementDelegation(long numCom)
    {
      long montantValidation = 0;
      int createur = 0;
      DateTime dateCre = DateTime.Now;
      long N6 = 0;
      long N2 = 0;
      long N3 = 0;
      long N4 = 0;

      try
      {
        // pas en place pour certaines filiales
        string[] filiales = { "EMALECFACILITEAM", "EMALECSUISSE", "EMAFI", "EMALECDEV" };
        if (Array.Exists(filiales, p => p == MozartParams.NomSociete)) return;

        // on ne traite pas les contrats aux détails mais uniquement les forfaits
        if (optCout0.Checked)
        {
          // s'il y avait une delegation, il faut la supprimer
          if (strStatutValidationCmd != "P")
          {
            MozartDatabase.ExecuteNonQuery($"delete from TCOMVALID where ctype='CS' and ncomnum= {numCom}");
            MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='P' where NCSTNUM = { numCom}");
          }
          return;
        }

        // recherche du total de la commande
        double montantContrat = Convert.ToDouble(txtFor.Text);

        //  recherche du créateur du contrat et de la date de creation
        string sSQL = $"SELECT NCSTCREA, DCSTDAT FROM TCST WHERE NCSTNUM= {numCom}";

        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            createur = Convert.ToInt32(sdr["NCSTCREA"]);
            dateCre = Convert.ToDateTime(sdr["DCSTDAT"]);
          }
        }
        // recherche du montant de validation du créateur
        sSQL = $"SELECT MTVALIDATION FROM TPER WHERE NPERNUM = {createur}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            montantValidation = (long)Utils.ZeroIfNull(sdr["MTVALIDATION"]);
          }
        }
        // en modification,  on supprime toute les données de validation (sauf le créateur) et on repart de zéro
        if (mstrStatutContrat == "M")
        {
          MozartDatabase.ExecuteNonQuery($"delete from TCOMVALID where ctype='CS' and ncomnum= {numCom}");
          // mise a jour du statut de la commande
          MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='P' where NCSTNUM = {numCom}");
        }
        // si montant supérieur, on sort sans création de délégation de dépense
        if (montantContrat < montantValidation)
        {
          if (mstrStatutContrat == "C")
          {
            // 26/04/2016, NL : Envoi d'un mail d'avertissement pour une nouvelle demande d'intervention
            MozartDatabase.ExecuteNonQuery($"exec api_sp_EnvoiMailNouvelleDemandeInterv {numCom}");
          }
          return;
        }
        //  suite si besoin
        //  CASE 1
        //  on insert une ligne dans la table de validation avec le createur de la commande en case 1
        MozartDatabase.ExecuteNonQuery($"insert into TCOMVALID (NCOMNUM, CTYPE, QN1, DN1, VRMQ) select {numCom},'CS',{createur}, '{dateCre}','{txtRmEng.Text.Replace("'", "''")}'");
        //  CASE 2
        //  recherche du responsable du compte et de l'assistant CHAFF pour cette commande
        sSQL = $"SELECT TCAN.NPERNUM AS NPERNUM_RESP, TCAN.NPERNUMASSCHAFF AS NPERNUM_ASSCHAFF FROM TCAN WITH(NOLOCK), TACT WITH(NOLOCK), TDIN WITH(NOLOCK), TCST WITH(NOLOCK) ";
        sSQL += $"WHERE TCAN.NCLINUM=TDIN.NCLINUM AND TACT.NDINNUM=TDIN.NDINNUM AND TCAN.NCANNUM=TDIN.NDINCTE AND TACT.NACTNUM = TCST.NACTNUM AND NCSTNUM = {numCom}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            N2 = Convert.ToInt32(sdr["NPERNUM_RESP"]);
            N6 = (long)Utils.ZeroIfNull(sdr["NPERNUM_ASSCHAFF"]);
          }
        }
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN2= {N2} where CTYPE='CS' AND NCOMNUM = {numCom}");
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN6= {N6} where CTYPE='CS' AND NCOMNUM = {numCom}");
        //  CASE 3 et 4
        //  recherche du groupe et du service
        sSQL = $"SELECT G.NPERNUM AS NPERNUM_GRP, S.NPERNUM AS NPERNUM_SVC FROM TREF_GROUPE G, TREF_SERVICE S, TPER P WHERE P.IDGROUPE=G.IDGROUPE AND G.IDSERVICE=S.IDSERVICE AND P.NPERNUM = {N2}";

        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            N3 = Convert.ToInt32(sdr["NPERNUM_GRP"]);
            N4 = Convert.ToInt32(sdr["NPERNUM_SVC"]);
          }
        }
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN3={N3} where CTYPE='CS' AND NCOMNUM = {numCom}");
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN4={N4} where CTYPE='CS' AND NCOMNUM = {numCom}");

        // CASE 5  direction par defaut, on enregistre personne pour le moment (uniquement à la signature)

        // mise a jour du statut de la commande
        MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='E' where NCSTNUM = {numCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void AfficheDelegation(long numCST)
    {
      try
      {
        // recherche si il y a des données de délégation
        string sSQL = $"exec api_sp_AfficheDelegation 'CS', {numCST}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            int i;
            // niveau 1.2.3.4.5
            for (i = 1; i <= 6; i++)
            {
              // affichage de la personne
              tlblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])}\r\n(<{Utils.ZeroIfNull(sdr["MT" + i])} €)";
              if (tlblPer[i].Text == "\r\n(<0 €)") tlblPer[i].Text = "";
              // on garde l'info du montant de validation
              tlblPer[i].Tag = Utils.ZeroIfNull(sdr["MT" + i]);
              // affichage de l'info de signature quand
              tlblSign[i].Text = $"{Utils.DateBlankIfNull(sdr["DN" + i], "dd/MM/yyyy")}\r\n{Utils.DateBlankIfNull(sdr["DN" + i], "HH:mm:ss")}";
              if (tlblSign[i].Text == "\r\n") tlblSign[i].Text = "";
              // on garde l'info de qui a validé
              tlblSign[i].Tag = Utils.BlankIfNull(sdr["QN" + i]);
              // case grise si validation nécessaire
              if (tlblPer[i].Text != "")
              {
                switch (i)
                {
                  case 1:
                    tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  case 2:
                    // si deleg 1 >= deleg 2
                    if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                      tlblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 1
                      if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[6].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 3:
                    // si deleg 1 >= deleg 3
                    if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                      tlblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 2
                      if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[2].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 4:
                    // si deleg 1 >= deleg 4
                    if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                      tlblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 3
                      if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[3].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 6:
                    // si deleg 1 >= deleg 5
                    if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                      tlblSign[i].BackColor = Color.White;
                    else
                      tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  default:
                    break;
                }
              }
            }

            // niveau direction --------------------------------
            i = 5;
            // cas direction
            // affichage de la personne
            if (Utils.BlankIfNull(sdr["QUI" + i]) == "")
              tlblPer[i].Text = "Direction \r\n (illimité)";
            else
              tlblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])}{Environment.NewLine}(illimité)";

            // on garde l'info du montant de validation
            tlblPer[i].Tag = Utils.ZeroIfNull(sdr["MT" + i]);
            // affichage de l'info de signature quand
            tlblSign[i].Text = $"{Utils.DateBlankIfNull(sdr["DN" + i], "dd/MM/yyyy")}\r\n{Utils.DateBlankIfNull(sdr["DN" + i], "HH:mm:ss")}";
            if (tlblSign[i].Text == "\r\n") tlblSign[i].Text = "";
            // on garde l'info de qui a validé
            tlblSign[i].Tag = Utils.BlankIfNull(sdr["QN" + i]);
            // case grise si validation nécessaire (si montant sup à validation du responsable de service)
            if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[i - 1].Tag))
              tlblSign[i].BackColor = MozartColors.ColorH8000000F;
            else
              tlblSign[i].BackColor = Color.White;

            // fin niveau direction --------------------------------

            // gestion de l'édition des commandes
            lblPer0.Text = Utils.BlankIfNull(sdr["QUIEDIT"]);
            lblSign0.Text = $"{Utils.DateBlankIfNull(sdr["DEDIT"], "dd/MM/yyyy")}\r\n{Utils.DateBlankIfNull(sdr["DEDIT"], "HH:mm:ss")}";
            if (lblSign0.Text == "\r\n") lblSign0.Text = "";
            lblSign0.Tag = Utils.BlankIfNull(sdr["QEDIT"]);

            // remarque sur délégation
            txtRmEng.Text = Utils.BlankIfNull(sdr["VRMQ"]);

            // titre du tableau
            if (strStatutValidationCmd == "E")
            {
              frameValidation.Text = "Autorisation des engagements de dépenses en attente de signature";
              frameValidation.ForeColor = Color.Red;
              cmdVisu.Enabled = false;
              cmdImprimer.Enabled = false;
            }
            else if (strStatutValidationCmd == "V")
            {
              frameValidation.Text = "Autorisation des engagements de dépenses validées, contrat à éditer et envoyer";
              frameValidation.ForeColor = Color.Orange;
              cmdVisu.Enabled = false;
              cmdImprimer.Enabled = false;
            }
            else if (strStatutValidationCmd == "I")
            {
              frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
              frameValidation.ForeColor = Color.Green;
              cmdVisu.Enabled = true;
              cmdImprimer.Enabled = true;
            }
            // tableau visible
            frameValidation.Visible = true;
            // test si affichage bouton analytique chantier
            if (cboLibChantierSTT.SelectedIndex != -1) CmdAnaChantier.Visible = true;
          }
          else
          {
            //si pas de données de validation, rien
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;
            frameValidation.Visible = false;
            CmdAnaChantier.Visible = false;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lblSignALL_Click(object sender, EventArgs e)
    {
      apiLabel apiL = (apiLabel)sender;

      int index = (int)Char.GetNumericValue(apiL.Name[7]);

      try
      {
        // case 1 pas de validation possible car si créateur, deja validé
        if (index == 1) return;
        // si déjà validé, pas utile de revalider
        if (tlblSign[index].Text != "") return;
        // si pas de hierarchie sortie (sauf si edition)
        if (tlblPer[index].Text == "" && index != 0) return;
        // on teste si le stt est interdit
        if (STFGRPInterdit(Convert.ToInt32(txtFields12.Tag)))
        {
          MessageBox.Show(Resources.msg_sousTraitInterdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // on teste son taux de depandance
        // test taux de dependance, si taux de dependance => 30 % alors message + exit
        if (ModuleMain.IsOKTauxDependanceSTF(Convert.ToInt32(txtFields12.Tag), MozartParams.NumAction, MozartParams.UID, MozartParams.NomSociete) == false) return;
        //  si index=5 (direction), c'est un cas particulier (chevalier, lazzarotto)
        if (index == 5)
        {
          // FGA le 260923 gestion de la societe dans la table de direction
          //          string sSQL = $"SELECT count(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER ON D.NPERNUM = dbo.TPER.NPERNUM INNER JOIN " +
          //                        $"TPER AS P ON dbo.TPER.VPERADSI = P.VPERADSI Where p.npernum = {MozartParams.UID}";
          string sSQL = $"SELECT COUNT(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER P ON D.NPERNUM = P.NPERNUM WHERE P.NPERNUM = {MozartParams.UID}";

          if ((int)MozartDatabase.ExecuteScalarInt(sSQL) == 1)
          {
            // on enregistre la validation et on valide la commande
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ? \r\n Voulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses. \r\n Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN{index}={MozartParams.UID}, DN{index}=GetDate() where CTYPE='CS' AND NCOMNUM = {mNumContratST}");
            MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID<>'I' And NCSTNUM = {mNumContratST}");
            strStatutValidationCmd = "V";
            frameValidation.Text = "Autorisation des engagements de dépenses validées, contrat à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange; // Orange
            tlblPer[index].Text = MozartParams.strUID;
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToString("T")}";
          }
          return;
        }

        // cas de l'edition de la commande
        if (index == 0)
        {
          if (strStatutValidationCmd != "V")
            MessageBox.Show("Le contrat doit être validé avant de pouvoir l'éditer", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          else
          {
            //on enregistre l'edition de la commande
            if (MessageBox.Show("Vous allez valider l'édition du contrat.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QEDIT={MozartParams.UID}, DEDIT=GetDate() where CTYPE='CS' AND NCOMNUM = {mNumContratST}");
            MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='I' where NCSTNUM = {mNumContratST}");
            strStatutValidationCmd = "I";
            tlblPer[index].Text = MozartParams.strUID;
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToString("T")}";
            frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
            frameValidation.ForeColor = Color.FromArgb(0, 128, 0); // Vert
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;
          }
          return;
        }

        // cas 3 (chef de Groupe)
        // BARBOSA, DALBEPIERRE et ... doivent se voir l'un l'autre.
        int[] ListeChefDeGroupe = { 226, 300, 1837, 1843, 3497, 3766, 4021, 4493, 3936, 622, 2066 };

        if (index == 3 && (Array.Exists(ListeChefDeGroupe, element => element == MozartParams.UID)))
        {
          if (Array.Exists(ListeChefDeGroupe, element => element == Convert.ToInt32(tlblSign[index].Tag)))   // ils ne peuvent valider que si c'est l'un d'eux en chef de groupe de ce contrat 
          {
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?\r\nVoulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }

            // mise a jour de la validation
            tlblPer[index].Tag = ModuleMain.GetMontantSeuilByNPERNUM(MozartParams.UID);

            MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN3=GetDate(), QN3={MozartParams.UID} where CTYPE='CS' AND NCOMNUM = {mNumContratST}");
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToString("T")}";
            // si cela valide la commande, changer le statut dans la commande
            // on a ici le montant de l'engagement de la personne initiale (si Sylvie à droit à 10000 et que Elodie valide pour Sylvie, elle peut valider pour 10000)
            // il faudra peut être modifier cela pour prendre en compte les montants spécifiques de chaque personne.
            if (Convert.ToDouble(tlblPer[index].Tag) >= Convert.ToDouble(txtFor.Text))
            {
              MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID<>'I' And NCSTNUM = {mNumContratST}");
              frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
              frameValidation.ForeColor = Color.Orange; // Orange
              strStatutValidationCmd = "V"; //modif du 11/09/2019 par mc : suite a la demande de pierre, avant il falait fermer la fenetre meme après une valition pour editer le contrat
            }
            return;
          }
        }

        // cas 4  (chef de service)
        // VIGUIER et DUMONT  ... doivent se voir l'un l'autre.
        int[] ListeChefDeService = { 1837, 4021 };

        if (index == 4 && (Array.Exists(ListeChefDeService, element => element == MozartParams.UID)))
        {
          if (Array.Exists(ListeChefDeService, element => element == Convert.ToInt32(tlblSign[index].Tag)))   // ils ne peuvent valider que si c'est l'un d'eux en chef de groupe de ce contrat 
          {
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?\r\nVoulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }

            // mise a jour de la validation
            tlblPer[index].Tag = ModuleMain.GetMontantSeuilByNPERNUM(MozartParams.UID);

            MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN4=GetDate(), QN4={MozartParams.UID} where CTYPE='CS' AND NCOMNUM = {mNumContratST}");
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToString("T")}";
            // si cela valide la commande, changer le statut dans la commande
            if (Convert.ToDouble(tlblPer[index].Tag) >= Convert.ToDouble(txtFor.Text))
            {
              MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID<>'I' And NCSTNUM = {mNumContratST}");
              frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
              frameValidation.ForeColor = Color.Orange; // Orange
              strStatutValidationCmd = "V"; //modif du 11/09/2019 par mc : suite a la demande de pierre, avant il falait fermer la fenetre meme après une valition pour editer le contrat
            }
            return;
          }
        }

        //  cas 2,3,4,6
        if (Convert.ToInt32(tlblSign[index].Tag) == MozartParams.UID)
        {
          if (txtRmEng.Text != "")
          {
            if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?\r\nVoulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          else
          {
            if (MessageBox.Show("Vous allez valider cet engagement de dépenses.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          // mise a jour de la validatiion
          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN{index}=GetDate() where CTYPE='CS' AND NCOMNUM = {mNumContratST}");
          tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToString("T")}";
          // si cela valide le contrat, changer le statut dans le contrat
          if (Convert.ToDouble(tlblPer[index].Tag) >= Convert.ToDouble(txtFor.Text))
          {
            MozartDatabase.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID<>'I' And NCSTNUM = {mNumContratST}");
            frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange; // Orange
            strStatutValidationCmd = "V"; //modif du 11/09/2019 par mc : suite a la demande de pierre, avant il falait fermer la fenetre meme après une valition pour editer le contrat
          }
          return;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtRmEng_Enter(object sender, EventArgs e)
    {
      framObs.Visible = true;
      framObs.BringToFront();
      TxtObs.Focus();
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      // position en début de text quand focus et avec saut de ligne
      string temp = $"{MozartParams.strUID} le {DateTime.Now:dd/MM/yy HH:mm:ss} : ";
      string msg = TxtObs.Text;

      if (msg == "") return;

      if (txtRmEng.Text == "")
        txtRmEng.Text = temp + msg;
      else
        txtRmEng.Text = temp + msg + "\r\n" + txtRmEng.Text;
      // enregistrement dans la base
      MozartDatabase.ExecuteNonQuery($"update TCOMVALID set VRMQ='{txtRmEng.Text.Replace("'", "''")}' where CTYPE='CS' AND NCOMNUM = {mNumContratST}");

      //envoi du mail au créateur d'une saisie de remarque
      if (msg != "") MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_EnvoiMsgDelegationAddObs] {mNumContratST}, 'CST'");

      framObs.Visible = false;
      bModif = false;
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private bool STFGRPInterdit(int nstfnum)
    {
      try
      {
        using (SqlDataReader sdrSTTInter = MozartDatabase.ExecuteReader($"exec api_sp_RetourInfoSttInterdit {nstfnum}"))
        {
          if (sdrSTTInter.Read())
            return Utils.BlankIfNull(sdrSTTInter["CNOTINTERDIT"]) == "O";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cboLibChantierSTT_SelectedIndexChanged(object sender, EventArgs e)
    {
      //****************************************************************************************************************
      //On peut changer la fiche chantier meme si laction est exécutée
      //****************************************************************************************************************
      if (mNumContratST != 0 && FrameLibChantierSTT.Visible == true && cboLibChantierSTT.SelectedIndex != 0 && cboLibChantierSTT.SelectedIndex != -1)
        MozartDatabase.ExecuteNonQuery($"exec api_sp_UpdateCSTFicheChantier {mNumContratST},{cboLibChantierSTT.SelectedValue}");
    }

    private void InitGrid()
    {
      try
      {
        // liste contrat en cours
        apiTGridH.AddColumn("Filiale", "VSOCIETE", 1000);
        apiTGridH.AddColumn("Client", "VCLINOM", 1900, "", 0, true);
        apiTGridH.AddColumn("Site", "VSITNOM", 1900, "", 0, true);
        apiTGridH.AddColumn("Chaff", "VDINCHAFF", 1200);
        apiTGridH.AddColumn("N° Ctr", "NCSTNUM", 1000);
        apiTGridH.AddColumn("Date contrat", "DCSTDAT", 900, "dd/mm/yy");
        apiTGridH.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
        apiTGridH.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

        apiTGridH.InitColumnList();

        // liste historique contrat sur 12 mois
        apiTGridB.AddColumn("Filiale", "VSOCIETE", 1000);
        apiTGridB.AddColumn("Client", "VCLINOM", 1900, "", 0, true);
        apiTGridB.AddColumn("Site", "VSITNOM", 1900, "", 0, true);
        apiTGridB.AddColumn("Chaff", "VDINCHAFF", 1200);
        apiTGridB.AddColumn("N° Ctr", "NCSTNUM", 1000);
        apiTGridB.AddColumn("Date contrat", "DCSTDAT", 900, "dd/mm/yy");
        apiTGridB.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
        apiTGridB.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

        apiTGridB.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void InitApiGridDoc()
    {
      try
      {
        apiTGrid2.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
        apiTGrid2.AddColumn("Statut", "VLIBSTATUT", 1100);
        apiTGrid2.AddColumn("Nb ctrts", "NBCST", 1000);
        apiTGrid2.AddColumn("CA STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
        apiTGrid2.AddColumn("CA emalec 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
        apiTGrid2.AddColumn("Dépendance %", "TAUX", 800, "##0.##", 1);
        apiTGrid2.AddColumn("Kbis", "DOC1", 1100);
        apiTGrid2.AddColumn("RC", "DOC2", 1100);
        apiTGrid2.AddColumn("Décennale", "DOC3", 1100);
        apiTGrid2.AddColumn("Sociale", "DOC4", 1100);
        apiTGrid2.AddColumn("Fiscale", "DOC5", 1100);
        apiTGrid2.AddColumn("Fluides", "DOC9", 1250);
        apiTGrid2.AddColumn("Conf & NC", "DOC10", 1200);
        apiTGrid2.AddColumn("CSTFGRPSANSDOC", "CSTFGRPSANSDOC", 0);  // pas de gestion des docs adm du STT

        apiTGrid2.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      // pas de gestion des couleurs si STT sans gestion des docs Admin
      if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["CSTFGRPSANSDOC"].ToString() == "O")
        return;

      // gestion spécifique des couleurs
      if (e.RowHandle >= 0 && (e.Column.Name == "DOC1" || e.Column.Name == "DOC2" || e.Column.Name == "DOC3" ||
          e.Column.Name == "DOC4" || e.Column.Name == "DOC5")) //|| e.Column.Name == "DOC10"))
      {
        if (e.CellValue != DBNull.Value)
        {
          if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
          if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
        }
        else
          e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
      }
      // gestion spécifique pour l'attestation fluide frigo
      if (e.RowHandle >= 0 && (e.Column.Name == "DOC9"))
      {  // si stt clim, alors doc obligatoire et gestion de la couleur
        if ((sender as GridView).GetDataRow(e.RowHandle)["FF"].ToString() != "0")
        {
          if (e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
          }
          else
            e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
        }
      }
    }

    private void CmdAnaChantier_Click(object sender, EventArgs e)
    {
      int i = (int)MozartDatabase.ExecuteScalarInt($"SELECT TCHANTIERFICHE.NIDCHANTIER FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDFICHE = {cboLibChantierSTT.SelectedValue}");

      if (i > 0)
        new frmXListeWithChiffrage("CHANTIER", i).ShowDialog();
    }

    private double MontantFacturesRavel(long lcontrat)
    {
      if (lcontrat == 0) return 0;

      return (double)ModuleData.ExecuteScalarDouble($"SELECT isnull(Sum(FHTANA),0) FROM TFOUFACCDE WHERE TFOUFACCDE.NCDENUM = {lcontrat} AND TFOUFACCDE.VTYPECDE = 'CS'");
    }

    private void chkEncours_Click(object sender, EventArgs e)
    {
      if (mNumContratST == 0) return;

      if (chkEncours.Checked)
        MozartDatabase.ExecuteScalarInt($"update TCST SET CCSTSENCOURS = 'O' where NCSTNUM = {mNumContratST}");
      else
        MozartDatabase.ExecuteScalarInt($"update TCST SET CCSTSENCOURS = 'N' where NCSTNUM = {mNumContratST}");
    }
  }
}