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
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmCommandeFournisseur : Form
  {
    // feuille ouverte en création ou modification
    public string mstrStatutCommande = "";
    public string mstrStatutAlerte = "";
    public int miNumCommande;
    public bool mbStock;
    public int miNumCom;

    //' Spécifique commande d'intérimaires (NL le 22/03/2017) :
    public string vNBInterim = "";
    public string vDTintervInterim = "";
    public string vHrintervInterim = "";
    public string vDureeIntervInterim = "";
    public string vTachesInterim = "";
    public string vCompetencesInterim = "";

    public DataTable dtArticle; //rsarticle
    DataTable dt = new DataTable(); //rs

    int iNumFournisseur;
    int iNumSiteFournisseur;
    string strStatutValidationCmd = "";
    bool bChargeCboFic;
    bool bCmdToSiteClient;

    public frmCommandeFournisseur() { InitializeComponent(); }

    private void frmCommandeFournisseur_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (mstrStatutCommande != "Q") dtArticle = new DataTable();
        else if (dtArticle == null)
        {
          MessageBox.Show(@"/!\ Le dtArticles doit être passé en paramètre /!\");
          return;
        }

        bCmdToSiteClient = false;

        if (MozartParams.CodePageDemarrage == "DELEGATION") { cmdRechercher.Visible = false; this.Text += $" - MODE DELEGATION"; }

        chkChantier.Visible = (MozartParams.NomSociete == "SCS");

        if (mstrStatutCommande != "Q") InitRecordsetArticle();

        grdDataGrid.GridControl.DataSource = dtArticle;
        FormatGrid();

        // remplir combo tech pour l'info des livraisons
        ModuleData.RemplirCombo(cboTech, "Exec [api_sp_comboTelTech]");
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "NOM";

        //recupération des articles cde de dt
        if (mstrStatutCommande == "Q")
        {
          MajDtArticle2();
          RemplirTxtTotaux();
        }

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      mbStock = false;
      mstrStatutAlerte = "";
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      //  enregistrement de la commande
      //  order by Fournisseur du recordset des articles
      //  creation d'un enregistrement avec numéro de commande par fournisseur
      //  enregistrement de toutes les lignes articles avec ce numero de commande
      // 
      //  enregistrement de la ligne de commande
      //  avec le recordset local,
      try
      {
        // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de commande
        //!!TOUT LE TEMPS A FALSE CAR mbFacture jamais a true dans frmListeCommandesFour
        // dans frmDetailstravaux.frm frmListeCommandesFour.bFacture = True ne s'applique pas si frmCommandeFournisseur est appelée
        /*frmListeCommandesFour f = new frmListeCommandesFour();
        if(f.mbFacture){
          MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }*/

        //  si il y a une facture dans Ravel, on ne peut pas modifier la commande
        int sSQL = MozartDatabase.ExecuteScalarInt($"SELECT count(*) FROM TFOUFACCDE WHERE TFOUFACCDE.NCDENUM = {miNumCommande}  AND TFOUFACCDE.VTYPECDE = 'CF'");
        if (sSQL > 0)
        {
          MessageBox.Show(Resources.msg_factureSaisieRavel, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (null == grdDataGrid.GetFocusedDataRow())
        {
          MessageBox.Show(Resources.msg_selection_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtDateLiv.Text == "")
        {
          MessageBox.Show(Resources.msg_DefinirDateLivr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (lblFicChantier.Visible == true && cboFicChantierFO.Text == "")
        {
          MessageBox.Show(Resources.msg_selectLibelleFicheChantierFour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // enregistrement ds factures
        // distinction des cas de modification et de creation
        if (mstrStatutCommande == "C")
        {
          CreationDesCommandes();
          Dispose();
        }
        else
        {
          // message si modification d'une commande déjà validée ou en cours de validation (E,V,I)
          if (strStatutValidationCmd != "P")
          {
            if (MessageBox.Show("Attention, si vous réenregistrez cette commande, les validations hiérarchiques seront supprimées", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) != DialogResult.Yes)
              return;

            MozartDatabase.ExecuteNonQuery($"DELETE FROM TCOM_VALID_SPEC WHERE CTYPE = 'CF' AND NCOMNUM = {miNumCommande}");
          }
          ModificationCommande();

          InitialiserFeuille();
        }

        // vérif si fournitures avec produit dangereux
        if (FouProduitDangerExist("TCOM", miNumCommande) == true)
        {
          MessageBox.Show($"Attention, vous allez utiliser une fourniture classée 'Produit dangereux'.\r\n" +
          $"A la validation de votre commande, vous allez recevoir par mail les fiches des produits concernés.\r\n" +
          $"Vous devez transmettre ces fiches à l'utilisateur et les intégrer dans votre dossier DOE.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

          //envoi du mail avec les fiches au créateur de la sortei de stock
          MozartDatabase.ExecuteNonQuery($"EXEC api_sp_EnvoiMailFicheProdDanger 'TCOM', {miNumCommande},'{MozartParams.NomSociete}'");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAlert_Click(object sender, EventArgs e)
    {
      if (mstrStatutCommande == "C") return;

      new frmSaisieAlertRavel
      {
        mstrType = "FOURNISSEUR",
        miNumObjet = miNumCommande
      }.ShowDialog();
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      editer(true);
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      editer(false);
    }

    // bPrint : true pour imprimer, false pour visualiser
    private void editer(bool bPrint)
    {
      if (mstrStatutCommande == "C") return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = miNumCommande.ToString(),
        InfosMail = $"TINT|NSTFNUM|{iNumSiteFournisseur}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = GetLangueByNSTFNUM(iNumSiteFournisseur),
        sOption = bPrint ? "PRINT" : "PREVIEW",
        strType = "CF",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

    private void cmdEmalec_Click(object sender, EventArgs e)
    {
      // dans la filiale, on souhaite faire une commande vers le fournisseur EMALEC
      try
      {
        // si il y a une facture dans Ravel, on ne peut pas modifier la commande
        if (mstrStatutCommande == "M")
        {
          MessageBox.Show("La facture de cette commande a été créée chez EMALEC.Vous ne pouvez plus modifier la commande", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (null == grdDataGrid.GetFocusedDataRow())
        {
          MessageBox.Show(Resources.msg_selection_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateLiv.Text == "")
        {
          MessageBox.Show(Resources.msg_DefinirDateLivr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  ajout module envoi directement au site client pour une commande à EMALEC
        switch (MessageBox.Show($"{Resources.msg_livrerCommandeSiteClient}\r\n{Resources.msg_OuiLivrSiteClient}\r\n{Resources.msg_NonLivrSiege} {MozartParams.NomSociete}",
                                Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Cancel:
            return;
          case DialogResult.Yes:
            bCmdToSiteClient = true;
            cboType.SelectedIndex = 1;
            cboType.Tag = "S";
            break;
          default:
            bCmdToSiteClient = false;
            break;
        }

        //  correction bug : par MC le 29/05/2018
        //  mise à jour du total par article
        //   parcours du recordset et mise à jour
        foreach (DataRow dr in dtArticle.Rows)
        {
          dr["Prix T"] = Utils.ZeroIfNull(dr["Prix U"]) * Utils.ZeroIfNull(dr["Quantite"]);
        }
        grdDataGrid.Requery(dtArticle, MozartDatabase.cnxMozart);

        if (mstrStatutCommande == "C")
        {
          Cursor = Cursors.WaitCursor;
          CreationCommandeEmalec();
          creationDiActionDDeFacture();
          Cursor = Cursors.Default;
          Dispose();
        }
        else ModificationCommande();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void creationDiActionDDeFacture()
    {
      // création d'une DI , d'une action, d'une sortie de stock, du chiffrage et de la facture
      MozartDatabase.ExecuteNonQuery($"Api_sp_CreationDIActionCmdEmalec {miNumCom}, {(bCmdToSiteClient ? 1 : 0)}");
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        // recherche des infos sur le site de livraison
        switch (((cboItemType)cboType.SelectedItem).CODE)
        {
          case 'E':
            using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_getInfosSociete {MozartParams.NumAction}"))
            {
              if (sdr.Read())
              {
                txtAdr1.Text = Utils.BlankIfNull(sdr["VSITAD1"]);//vb6:Me.txtFields(0) 
                txtAdr2.Text = Utils.BlankIfNull(sdr["VSITAD2"]);//vb6:Me.txtFields(1) 
                txtCP.Text = Utils.BlankIfNull(sdr["VSITCP"]);//vb6:Me.txtFields(2) 
                txtVille.Text = Utils.BlankIfNull(sdr["VSITVIL"]);//vb6:Me.txtFields(3) 

                if (mstrStatutCommande == "C") txtAttention.Text = Utils.BlankIfNull(sdr["VPERNOM"]);//vb6:Me.txtFields(4)
                lblDest.Text = Resources.col_Site;
                txtLivr.Text = MozartParams.GetNomSociete();
                enableControls(false);
                cboTech.Visible = false;
              }
            }
            break;
          case 'S':
            using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_getSITE {MozartParams.NumAction}"))
            {
              if (sdr.Read())
              {
                txtAdr1.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
                txtAdr2.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
                txtCP.Text = Utils.BlankIfNull(sdr["VSITCP"]);
                txtVille.Text = Utils.BlankIfNull(sdr["VSITVIL"]);

                if (mstrStatutCommande == "C") txtAttention.Text = "Technicien " + MozartParams.GetNomSociete(); ;
                lblDest.Text = Resources.col_Site;
                txtLivr.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
                enableControls(false);
                cboTech.Visible = true;
              }
            }
            break;
          case 'T':
            //    si on est en création, on prend le tech sur l'action
            //    si on est en modif, on prend le tech sur la commande
            if (mstrStatutCommande == "C")
            {
              using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_getTECH {MozartParams.NumAction},0"))
              {
                if (sdr.Read())
                {
                  txtAdr1.Text = Utils.BlankIfNull(sdr["VPERAD1"]);
                  txtAdr2.Text = Utils.BlankIfNull(sdr["VPERAD2"]);
                  txtCP.Text = Utils.BlankIfNull(sdr["VPERCP"]);
                  txtVille.Text = Utils.BlankIfNull(sdr["VPERVIL"]);
                  txtAttention.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                  lblDest.Text = "Nom";
                  txtLivr.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                }
                else
                {
                  MessageBox.Show(Resources.msg_selectTechAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  cboType.SelectedIndex = 0;
                }
              }
            }
            else
            {
              // on prend le tech sur la commande
              using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_getTECH 0, {miNumCommande}"))
              {
                if (sdr.Read())
                {
                  txtAdr1.Text = Utils.BlankIfNull(sdr["VPERAD1"]);
                  txtAdr2.Text = Utils.BlankIfNull(sdr["VPERAD2"]);
                  txtCP.Text = Utils.BlankIfNull(sdr["VPERCP"]);
                  txtVille.Text = Utils.BlankIfNull(sdr["VPERVIL"]);
                  txtAttention.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                  txtLivr.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                  lblDest.Text = "Nom";
                }
                else
                {
                  // si pas de tech sur la commande, on le prend sur l'action
                  using (SqlDataReader sdr2 = MozartDatabase.ExecuteReader($"api_sp_getTECH  {MozartParams.NumAction}, 0"))
                  {
                    if (sdr2.Read())
                    {
                      txtAdr1.Text = Utils.BlankIfNull(sdr["VPERAD1"]);
                      txtAdr2.Text = Utils.BlankIfNull(sdr["VPERAD2"]);
                      txtCP.Text = Utils.BlankIfNull(sdr["VPERCP"]);
                      txtVille.Text = Utils.BlankIfNull(sdr["VPERVIL"]);
                      txtAttention.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                      txtLivr.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
                      lblDest.Text = "Nom";
                    }
                    else
                    {
                      // si pas de tech sur l'action, erreur
                      MessageBox.Show(Resources.msg_erreurPasTechnicienAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  }
                }
              }
            }
            enableControls(false);
            cboTech.Visible = false;
            break;
          case 'A':
            //libre adresse
            if (mstrStatutCommande == "C")
              txtAdr1.Text = txtAdr2.Text = txtCP.Text = txtVille.Text = txtAttention.Text = txtLivr.Text = "";
            else
            {
              using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_getAUTRES {MozartParams.NumAction}, {miNumCommande}"))
              {
                if (sdr.Read())
                {
                  txtAdr1.Text = Utils.BlankIfNull(sdr["VCOMAD1"]);
                  txtAdr2.Text = Utils.BlankIfNull(sdr["VCOMAD2"]);
                  txtCP.Text = Utils.BlankIfNull(sdr["VCOMCP"]);
                  txtVille.Text = Utils.BlankIfNull(sdr["VCOMVIL"]);
                  txtLivr.Text = Utils.BlankIfNull(sdr["VCOMLLI"]);
                }
              }
            }
            lblDest.Text = "Nom";
            enableControls(true);
            cboTech.Visible = false;
            break;
          default:
            break;
        }
        txtAttention.Enabled = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void enableControls(bool bEnable)
    {
      FontStyle lFont;

      try
      {
        lFont = bEnable ? FontStyle.Regular : FontStyle.Bold;

        apiTextBox[] tabTxtFields = { txtAdr1, txtAdr2, txtCP, txtVille, txtAttention };
        for (int i = 0; i < tabTxtFields.Length; i++)
        {
          tabTxtFields[i].Enabled = bEnable;
          tabTxtFields[i].Font = new Font(tabTxtFields[i].Font, lFont);
        }

        txtAttention.Enabled = true;

        apiLabel[] tabLblAdress = { lbladresse0, lbladresse1, lbladresse2, lbladresse3, lbladresse4 };
        for (int i = 0; i < tabLblAdress.Length; i++)
        {
          tabLblAdress[i].BackColor = MozartColors.ColorHC0FFFF;
        }

        framAdr.BackColor = MozartColors.ColorHC0FFFF;
        txtLivr.Enabled = bEnable;
        txtLivr.Font = new Font(txtLivr.Font, lFont);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      try
      {
        // affichage de la feuille  de recherche des fournitures avec numero de fournisseur si connu
        Cursor = Cursors.WaitCursor;
        new frmRechercheArticlesCom
        {
          miNumFournisseur = iNumFournisseur,
          m_brechercheSite = true,
          m_bSaisieQte = true,
          mstrClient = txtcli0.Text,
          mstrStatut = "CDE",
          m_bAfficheInfoFou = true,
          mdtArticles = dtArticle,
          m_bStock = true
        }.ShowDialog();

        // remplir les montants totaux
        RemplirTxtTotaux();

        // si on est en création de commande, on recherche les frais de port sur le fournisseur
        DataRow currentRow = grdDataGrid.GetFocusedDataRow();

        if (mstrStatutCommande == "C" && dtArticle.Rows.Count > 0 && currentRow != null) AfficherInfoFraisPort(Convert.ToInt64(currentRow["NumFour"]));

        if (currentRow == null) return;

        if (currentRow["Serie"].ToString() == "Intérimaire" && TxtComplementInterimaire.Text == "")
        {
          new frmCommandeInterim().ShowDialog();

          // RechercheTexteInterimaireParDefaut
          TxtComplementInterimaire.Text = $"COMMANDE DE PRESTATION INTERIMAIRE :{Environment.NewLine}{Environment.NewLine}Lieu d'intervention : Voir \"Lieu de livraison\" en en-tête, à gauche, de cette commande (Site){Environment.NewLine}{Environment.NewLine}" +
          $"Nombre de personnes demandé : {vNBInterim}{Environment.NewLine}" +
          $"Date et heure du début de l'intervention : {vDTintervInterim}{vHrintervInterim}{Environment.NewLine}" +
          $"Durée approximative de l'intervention : {vDureeIntervInterim}{Environment.NewLine}{Environment.NewLine}" +
          $"Voici les taches qui vont être demandées aux personnes intérimaires intervenantes :{Environment.NewLine}{vTachesInterim}{Environment.NewLine}{Environment.NewLine}" +
          $"Les compétences nécessaires requises sont les suivantes :{Environment.NewLine}{ vCompetencesInterim}{Environment.NewLine}{Environment.NewLine}" +
          $"Les personnes intervenantes devront être équipées de tous les Equipements de Protection Individuelle nécessaires.{Environment.NewLine}" +
          $"Les personnes intervenantes devront posséder les habilitations et qualifications nécessaires.";

          TxtComplementInterimaire.Visible = true;
          lblLabelInterim.Visible = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor = Cursors.Default; }
    }

    private void RemplirTxtTotaux()
    {
      try
      {
        double dHT = 0;

        foreach (DataRow dr in dtArticle.Rows)
        {
          dHT += Utils.ZeroIfNull(dr["Prix T"]);
        }

        txtHT.Text = Strings.Format(dHT, "currency");
        txtTVA.Text = Strings.Format((dHT * MozartParams.TVA1 / 100), "currency");
        txtTTC.Text = Strings.Format((dHT + (dHT * (MozartParams.TVA1 / 100))), "currency");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        // on prend l'index correct
        switch (cboType.Tag)
        {
          case "E":
            cboType.SelectedIndex = 0;
            break;
          case "S":
            cboType.SelectedIndex = 1;
            break;
          case "T":
            cboType.SelectedIndex = 2;
            break;
          case "A":
            cboType.SelectedIndex = 3;
            break;
          default:
            break;
        }

        // recherche de la date de livraison
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourDateLivCom {miNumCommande}"))
        {
          if (sdr.Read())
          {
            if (sdr["DCOMDLI"] != DBNull.Value) txtDateLiv.DateTime = Convert.ToDateTime(sdr["DCOMDLI"]);
            txtRmq.Text = Utils.BlankIfNull(sdr["VCOMRMQ"]);
            if (sdr["DCOMPLA"] != DBNull.Value) txtDatePlanif.DateTime = Convert.ToDateTime(sdr["DCOMPLA"]);
            TxtComplementInterimaire.Text = Utils.BlankIfNull(sdr["VCOMPLINTERIM"]);
            TxtRemInterne.Text = Utils.BlankIfNull(sdr["VCOMREM_INTERNE"]);
          }
        }

        if (TxtComplementInterimaire.Text != "")
        {
          TxtComplementInterimaire.Visible = true;
          lblLabelInterim.Visible = true;
        }

        //  recherche des détails fournitures
        dt.Rows.Clear();
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourArticlesCommande {iNumFournisseur}, {miNumCommande}"))
        {
          dt.Load(sdr);
        }
        dtArticle.Rows.Clear();
        foreach (DataRow dr in dt.Rows)
        {
          AjouterEnrg(dr);
        }

        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AfficherInfoFraisPort(long nstfgrpnum)
    {
      using (SqlDataReader sdrReq = MozartDatabase.ExecuteReader($"SELECT  NSTFGRPMTTPORT,VSTFGRPFRANCO FROM TSTFGRP WHERE NSTFGRPNUM ={nstfgrpnum}"))
      {
        if (sdrReq.Read())
        {
          txtMtFranco.Text = Utils.BlankIfNull(sdrReq["NSTFGRPMTTPORT"]);
          txtMtPort.Text = Utils.BlankIfNull(sdrReq["VSTFGRPFRANCO"]);
        }
      }
    }

    public void FormatGrid()
    {
      grdDataGrid.AddColumn(Resources.col_Serie, "Serie", 0);
      grdDataGrid.AddColumn(Resources.col_materiel, "Article", 2300);
      grdDataGrid.AddColumn(Resources.col_marque, "Marque", 1500);
      grdDataGrid.AddColumn(Resources.col_Type, "Type", 1500);
      grdDataGrid.AddColumn(Resources.col_reference, "Reference", 1200);
      grdDataGrid.AddColumn("PCB", "PCB", 800, "", 2);
      grdDataGrid.AddColumn(Resources.col_prixU, "Prix U", 900, "## ##0.000", 1);
      grdDataGrid.AddColumn("Qté", "Quantite", 800, "", 2);
      grdDataGrid.AddColumn(Resources.col_prixT, "Prix T", 0);
      grdDataGrid.AddColumn(Resources.col_Fournisseur, "Fournisseur", 1400);
      grdDataGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
      grdDataGrid.AddColumn(Resources.col_num_four, "NumFour", 0);
      grdDataGrid.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);
      grdDataGrid.InitColumnList();
    }

    private void InitialiserFeuille()
    {
      try
      {
        // on rempli la combo pour proposer le nom de la societe 
        RemplirComboType();

        //recherche des infos de la commande  (que la commande existe ou pas)
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourInfoCommandesFO {miNumCommande}, {MozartParams.NumAction}"))
        {
          if (sdr.Read())
          {
            // les infos de la feuille
            txtcli0.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtcli1.Text = Utils.BlankIfNull(sdr["NDINCTE"]);
            txtcli2.Text = Utils.DateBlankIfNull(sdr["DCOMDAT"]);
            txtcli3.Text = Utils.BlankIfNull(sdr["NCOMNUM"]);

            // recupération du numéro  de client
            txtcli0.Tag = (int)Utils.ZeroIfNull(sdr["NCLINUM"]);

            bChargeCboFic = false;

            //  inint
            txtRmEng.Text = "";

            // si on est en modification ou en création
            if (Utils.BlankIfNull(sdr["NCOMNUM"]) == "0")
            {
              mstrStatutCommande = "C";
              miNumCommande = 0;
              iNumFournisseur = 0;
              iNumSiteFournisseur = 0;
              cboType.SelectedIndex = 0; // par défaut on prend emalec comme livraison
              if ((int)Utils.ZeroIfNull(sdr["CHANTIER"]) == 0)
              {
                lblFicChantier.Visible = false;
                cboFicChantierFO.Visible = false;
              }
              else
              {
                lblFicChantier.Visible = true;
                cboFicChantierFO.Visible = true;
                //On charge la combo des libellés fiche chantier
                string sql;
                if (MozartParams.NomSociete == "EMALECMPM")
                  sql = $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER " +
                        $" WHERE VTYPE = 'F' AND NCANNUM = {sdr["NDINCTE"]}  AND VSOCIETE = '{MozartParams.NomSociete}' AND TCHANTIERFICHE.NIDANACHAFICTYPE <> 3 ORDER BY TCHANTIERFICHE.NCLASS";
                else
                  sql = $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER " +
                        $" WHERE VTYPE = 'F' AND NCANNUM = {sdr["NDINCTE"]}  AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TCHANTIERFICHE.NCLASS";

                ModuleData.RemplirCombo(cboFicChantierFO, sql, true);
                cboFicChantierFO.ValueMember = "NIDFICHE";
                cboFicChantierFO.DisplayMember = "VLIB";

                bChargeCboFic = true;
              }

              // a la creation, si l'action est contenu dans une action reappro filiale auto alors on passe le destinataire à AUTRE et on saisie en auto l'adresse du tech
              // destinataire
              if (mbStock == true)
              {
                int NPERNUM_DEST_DDE = IsCommandeReapproFillialeAuto(MozartParams.NumAction);

                if (NPERNUM_DEST_DDE > 0)
                {
                  // get infos technicien filliale
                  cboType.SelectedText = Resources.txt_autre;

                  using (SqlDataReader sdrPerDest = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetTPER_BY_NPERNUM] {NPERNUM_DEST_DDE}"))
                  {
                    if (sdrPerDest.Read())
                    {
                      txtLivr.Text = "Domicile tech Filiale";
                      txtAdr1.Text = Utils.BlankIfNull(sdrPerDest["VPERAD1"]);
                      txtAdr2.Text = Utils.BlankIfNull(sdrPerDest["VPERAD2"]);
                      txtCP.Text = Utils.BlankIfNull(sdrPerDest["VPERCP"]);
                      txtVille.Text = Utils.BlankIfNull(sdrPerDest["VPERVIL"]);
                      txtAttention.Text = Utils.BlankIfNull(sdrPerDest["VPERNOM"]);
                    }
                  }
                }
              }

              cmdEnregDateLivr.Visible = false;
              cmdEnregRemInterne.Visible = false;
            }
            else
            {
              mstrStatutCommande = "M";
              cboType.Tag = Utils.BlankIfNull(sdr["VCOMTYP"]);
              miNumCommande = Convert.ToInt32(Strings.Mid(sdr["NCOMNUM"].ToString(), 3));
              iNumFournisseur = Convert.ToInt32(sdr["NSTFGRPNUM"]);
              iNumSiteFournisseur = Convert.ToInt32(sdr["NSTFNUM"]);
              txtAttention.Text = Utils.BlankIfNull(sdr["VCOMATT"]);
              txtMtFranco.Text = Utils.BlankIfNull(sdr["NSTFGRPMTTPORT"]);
              txtMtPort.Text = Utils.BlankIfNull(sdr["VSTFGRPFRANCO"]);
              if ((int)Utils.ZeroIfNull(sdr["CHANTIER"]) == 0)
              {
                lblFicChantier.Visible = false;
                cboFicChantierFO.Visible = false;
              }
              else
              {
                lblFicChantier.Visible = true;
                cboFicChantierFO.Visible = true;
                // On charge la combo des libellés fiche chantier
                ModuleData.RemplirCombo(cboFicChantierFO, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER " +
                                                          $" WHERE VTYPE = 'F' AND NCANNUM = {sdr["NDINCTE"]}  AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY VLIB", true);
                cboFicChantierFO.ValueMember = "NIDFICHE";
                cboFicChantierFO.DisplayMember = "VLIB";

                cboFicChantierFO.SelectedValue = (int)Utils.ZeroIfNull(sdr["NIDFICHE"]);
                bChargeCboFic = true;
              }

              chkChantier.Checked = (Utils.ZeroIfNull(sdr["BCOMCHANTIER"]) == 1);

              // si c'est 1 commande issu d une commande de reappro filiale
              if (Convert.ToInt32(sdr["NCOMNUM_FILIALE"]) > 0)
              {
                cmdValider.Visible = false;
                MessageBox.Show(Resources.msg_pasModifierCmdDejaGenereeAuto, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }

              OuvertureEnModification();

              //traitement delegation
              strStatutValidationCmd = Utils.BlankIfNull(sdr["CCOMVALID"]);
              AfficheDelegation(miNumCommande);

              cmdEnregDateLivr.Visible = true;
              cmdEnregRemInterne.Visible = true;
            }

            //  COULEUR DU BOUTON ALERT : jaune si une alerte a ete saisie
            if (Utils.BlankIfNull(sdr["VCOMALERT"]) != "N" && Utils.BlankIfNull(sdr["VCOMALERT"]) != "") cmdAlert.BackColor = Color.Yellow;
          }
        }
        // on désactive le bouton de validation si on vient de l'alerte pour éviter les ambiguités de validation
        cmdValider.Enabled = !(mstrStatutAlerte == "OUI");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void InitRecordsetArticle()
    {
      // ajout des champs 
      dtArticle.Columns.Add("Serie", typeof(string));
      dtArticle.Columns.Add("Article", typeof(string));
      dtArticle.Columns.Add("Marque", typeof(string));
      dtArticle.Columns.Add("Type", typeof(string));
      dtArticle.Columns.Add("Reference", typeof(string));
      dtArticle.Columns.Add("PCB", typeof(int));
      dtArticle.Columns.Add("Prix U", typeof(double));
      dtArticle.Columns.Add("Quantite", typeof(long));
      dtArticle.Columns.Add("Prix T", typeof(double));
      dtArticle.Columns.Add("Fournisseur", typeof(string));
      dtArticle.Columns.Add("NumArticle", typeof(int));
      dtArticle.Columns.Add("NumFour", typeof(int));
      dtArticle.Columns.Add("NumSiteFour", typeof(int));
    }

    private void CreationDesCommandes()
    {
      try
      {
        dtArticle.DefaultView.Sort = "NumFour";
        dtArticle = dtArticle.DefaultView.ToTable();

        //initialisation des variables de rupture
        int iNumFour = 0;
        miNumCom = 0;
        //parcours de la datatable et gestion des ruptures
        foreach (DataRow row in dtArticle.Rows)
        {
          if (iNumFour == 0)
          {
            //création d'une nouvelle commande
            EnregCommande(0, row);
          }
          else
          {
            if (iNumFour == (int)Utils.ZeroIfNull(row["NumFour"]))//on reste sur le même fournisseur
              EnregCommande(miNumCom, row);
            else
            { // on change de fournisseur donc nouvelle commande
              // mise à jour dans l'obs de TACT
              MozartDatabase.ExecuteNonQuery($"api_sp_UpdateActionCom {miNumCom}, 'N', ''");
              //envoie mail si commande a destination du site (phildar)
              MozartDatabase.ExecuteNonQuery($"api_sp_SendMailExpeditionCF {miNumCom}");
              //envoie mail si commande de fournitures qui sont en stock magasin
              MozartDatabase.ExecuteNonQuery($"api_sp_SendMailAlertCmd {miNumCom}");

              //traitement delegation pouvoir
              TraitementDelegation(miNumCom);

              EnregCommande(0, row);
            }
          }
          iNumFour = (int)Utils.ZeroIfNull(row["NumFour"]);
        }

        //  traitement de la derniere commande (si plusieurs) ou de la premiere commande (si une seule)
        //  mise a jour dans l'obs de TACT
        MozartDatabase.ExecuteNonQuery($"api_sp_UpdateActionCom {miNumCom}, 'N',''");

        // envoie mail si commande a destination du site (phildar)
        //MozartDatabase.ExecuteNonQuery($"api_sp_SendMailExpeditionCF {miNumCom}");

        //  traitement delegation pouvoir
        TraitementDelegation(miNumCom);

        // traitement de la envoie mail si commande de fournitures qui sont en stock magasin
        MozartDatabase.ExecuteNonQuery($"api_sp_SendMailAlertCmd {miNumCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void TraitementDelegation(int numCom)
    {
      try
      {
        int createur = 0;
        string datecre = "";
        string lReq;
        long N6 = 0;
        long N2 = 0;

        //  pas de délégation pour certaines société
        string[] filiales = { "EMALECFACILITEAM", "EMALECSUISSE", "SAMSICROMANIA", "EMALECDEV" };
        if (Array.Exists(filiales, p => p == MozartParams.NomSociete)) return;

        // recherche du total de la commande
        double sSQL = (double)ModuleData.ExecuteScalarDouble($"SELECT sum(NLCOPT) FROM TLCO WHERE ncomnum={numCom}");
        double MontantCommande = sSQL;

        // recherche du créateur de la commande et de la date de creation
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"SELECT NQUICREE, DCOMDAT FROM TCOM WHERE NCOMNUM={numCom}"))
        {
          if (sdr.Read())
          {
            createur = (int)Utils.ZeroIfNull(sdr["NQUICREE"]);
            if (Utils.BlankIfNull(sdr["DCOMDAT"]) == "") datecre = "";
            else datecre = Utils.DateLongBlankIfNull(sdr["DCOMDAT"]);
          }
        }

        // recherche du montant de validation du créateur
        sSQL = (double)ModuleData.ExecuteScalarDouble($"SELECT MTVALIDATION FROM TPER WHERE NPERNUM ={createur}");
        double MontantValidation = Utils.ZeroIfNull(sSQL);

        //  en modification de commande, on supprime toute les données de validation (sauf le créateur de la commande et les remarques) et on repart de zéro
        if (mstrStatutCommande == "M")
        {
          MozartDatabase.ExecuteNonQuery($"delete from TCOMVALID where  CTYPE='CF' AND NCOMNUM={numCom}");
          // mise à jour du statut de la commande
          MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='P' where NCOMNUM = {numCom}");
        }

        //  si montant supérieur, on sort sans création de délégation de dépense sauf s'il y a des fluides frigo 29/06/2020par MC
        if (MontantCommande < MontantValidation) return;

        //  suite si besoin
        // CASE 1
        //  on insert une ligne dans la table de validation avec le createur de la commande en case 1
        MozartDatabase.ExecuteNonQuery($"insert into TCOMVALID (NCOMNUM, CTYPE, QN1, DN1, VRMQ) select {numCom},'CF',{createur}, '{datecre}','{txtRmEng.Text.Replace("'", "''")}'");

        //  CASE 2, 6
        //  recherche du responsable du compte et de l'assistant CHAFF pour cette commande
        lReq = $"SELECT TCAN.NPERNUM AS NPERNUM_RESP, TCAN.NPERNUMASSCHAFF AS NPERNUM_ASSCHAFF FROM TCAN WITH(NOLOCK), TACT WITH(NOLOCK), TDIN WITH(NOLOCK), TCOM WITH(NOLOCK)";
        lReq += $" WHERE TCAN.NCLINUM=TDIN.NCLINUM AND TACT.NDINNUM=TDIN.NDINNUM AND TCAN.NCANNUM=TDIN.NDINCTE AND TACT.NACTNUM = TCOM.NACTNUM AND NCOMNUM = {numCom}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(lReq))
        {
          if (sdr.Read())
          {
            N2 = Convert.ToInt32(sdr["NPERNUM_RESP"]);
            N6 = (long)Utils.ZeroIfNull(sdr["NPERNUM_ASSCHAFF"]);
          }
        }
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN2= {N2}, QN6= {N6} where CTYPE='CF' AND NCOMNUM = {numCom}");

        // CASE 3 et 4
        // recherche du groupe et du service
        int n3 = 0, n4 = 0;
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"SELECT G.NPERNUM AS NPERNUM_GRP, S.NPERNUM AS NPERNUM_SVC FROM TREF_GROUPE G, TREF_SERVICE S, TPER P WHERE P.IDGROUPE=G.IDGROUPE AND G.IDSERVICE=S.IDSERVICE AND P.NPERNUM = {N2}"))
        {
          if (sdr.Read())
          {
            n3 = (int)Utils.ZeroIfNull(sdr["NPERNUM_GRP"]);
            n4 = (int)Utils.ZeroIfNull(sdr["NPERNUM_SVC"]);
          }
        }
        MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN3={n3}, QN4={n4} where CTYPE='CF' AND NCOMNUM = {numCom}");

        // CASE 5  direction par defaut, on enregistre personne pour le moment (uniquement à la signature)

        //  mise a jour du statut de la commande
        MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='E' where NCOMNUM = {numCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void AfficheDelegation(long numCom)
    {
      try
      {
        DateTime dn;
        // recherche si il y a des données de délégation
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"exec api_sp_AfficheDelegation 'CF', {numCom}"))
        {
          if (sdr.Read())
          {
            apiLabel[] lblNiv = { null, lblniv1, lblniv2, lblniv3, lblniv4, lblniv5, lblniv7 };
            apiLabel[] lblPer = { null, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer7 };
            apiLabel[] lblSign = { null, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5, lblSign7 };

            // Remplissage des composants
            for (int i = 1; i < lblNiv.Length; i++)
            {
              lblNiv[i].Visible = true;
              lblPer[i].Visible = true;
              lblSign[i].Visible = true;

              // affichage de la personne
              if (i == 5)
              {
                // Cas du niveau direction
                if (Utils.BlankIfNull(sdr["QUI" + i]) == "")
                  lblPer[i].Text = $"Direction {Environment.NewLine} (illimité)";
                else
                  lblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])} {Environment.NewLine} (illimité)";
              }
              else
              {
                // Autres cas
                lblPer[i].Text = Utils.BlankIfNull(sdr["QUI" + i]) + $"{Environment.NewLine} (< " + Utils.BlankIfNull(sdr["MT" + i].ToString()) + " €)";
                if (lblPer[i].Text == $"{Environment.NewLine} (< 0 €)") lblPer[i].Text = "";
              }

              // on garde l'info du montant de validation
              lblPer[i].Tag = Utils.ZeroIfNull(sdr["MT" + i]);
              // affichage de l'info de signature quand       
              lblSign[i].Text = "";
              if (DateTime.TryParse(Utils.BlankIfNull(sdr["DN" + i]), out dn))
                lblSign[i].Text = $"{dn.ToShortDateString()}{Environment.NewLine}{dn.TimeOfDay}";
              // on garde l'info de qui a validé
              lblSign[i].Tag = (int)Utils.ZeroIfNull(sdr["QN" + i]);
            }

            // Mise à jour des couleurs
            for (int i = 1; i < lblNiv.Length; i++)
            {
              // case grise si validation nécessaire
              if (lblPer[i].Text != "")
              {
                switch (i)
                {
                  case 1:
                    lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  case 6:
                    //si deleg 1 >= deleg 6
                    if ((double)lblPer1.Tag > Convert.ToDouble(lblPer[i].Tag)) lblSign[i].BackColor = Color.White;
                    else lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  case 2:
                    //  si deleg 1 >= deleg 2
                    if ((double)lblPer1.Tag >= Convert.ToDouble(lblPer[i].Tag)) lblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 6
                      if (double.Parse(txtHT.Text, NumberStyles.Currency) > (double)lblPer7.Tag) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 3:
                    //  si deleg 1 >= deleg 3
                    if ((double)lblPer1.Tag >= Convert.ToDouble(lblPer[i].Tag)) lblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 2
                      if (double.Parse(txtHT.Text, NumberStyles.Currency) > (double)lblPer2.Tag) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 4:
                    // si deleg 1 >= deleg 4
                    if ((double)lblPer1.Tag >= (double)lblPer[i].Tag) lblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg 3
                      if (double.Parse(txtHT.Text, NumberStyles.Currency) > (double)lblPer3.Tag) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 5:
                    // si montant sup à validation du responsable de service
                    if (double.Parse(txtHT.Text, NumberStyles.Currency) > Convert.ToDouble(lblPer4.Tag)) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    else lblSign[i].BackColor = Color.White;
                    break;
                  default:
                    break;
                }
              }
            }

            // remarque sur délégation
            txtRmEng.Text = Utils.BlankIfNull(sdr["VRMQ"]);

            // droit spécifique **************************************************************************************************************
            // gris
            lblSign6.BackColor = MozartColors.ColorH8000000F;
            // SUPPRIMER CE CODE LE JOURS DE SA MISE EN PROD
            lblniv6.Visible = false;
            lblPer6.Visible = false;
            lblSign6.Visible = false;

            // gestion de l'édition des commandes
            lblPer0.Text = Utils.BlankIfNull(sdr["QUIEDIT"]);
            lblSign0.Text = "";
            if (DateTime.TryParse(Utils.BlankIfNull(sdr["DEDIT"]), out dn))
              lblSign0.Text = $"{dn.ToShortDateString()}{Environment.NewLine}{dn.TimeOfDay}";
            lblSign0.Tag = (int)Utils.ZeroIfNull(sdr["QEDIT"]);

            //  titre du tableau
            switch (strStatutValidationCmd)
            {
              case "E":
                frameValidation.Text = "Autorisation des engagements de dépenses en attente de signature";
                frameValidation.ForeColor = Color.Red;
                cmdVisu.Enabled = false;
                cmdImprimer.Enabled = false;
                break;
              case "V":
                frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
                frameValidation.ForeColor = Color.Orange;
                cmdVisu.Enabled = false;
                cmdImprimer.Enabled = false;
                break;
              case "I":
                frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
                frameValidation.ForeColor = Color.Green;
                cmdVisu.Enabled = true;
                cmdImprimer.Enabled = true;
                break;
              default:
                break;
            }

            // tableau visible
            frameValidation.Visible = true;

            // test si affichage bouton analytique chantier
            if (cboFicChantierFO.SelectedIndex != -1) CmdAnaChantier.Visible = true;
          }
          else
          {
            //si pas de données de validation, rien
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;

            using (SqlDataReader sdrDroitSpec = MozartDatabase.ExecuteReader($"EXEC [api_sp_Delegation_Spec_Detail] {miNumCommande}, 'CF'"))
            {
              if (!sdrDroitSpec.Read()) frameValidation.Visible = false;
            }
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
      int index = (int)Char.GetNumericValue((sender as apiLabel).Name[7]);
      //pas de validation possible car si créateur, deja validé
      if (index == 1) return;

      apiLabel[] lblSign = { lblSign0, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5, lblSign6, lblSign7 };
      apiLabel[] lblPer = { lblPer0, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer6, lblPer7 };

      //si déjà validé, pas utile de revalider
      if (lblSign[index].Text != "") return;
      //si pas de hierarchique sortir (sauf si edition)
      if (lblPer[index].Text == "" && index != 0) return;

      //si index=5 (direction)
      if (index == 5)
      {
        // FGA le 260923 gestion de la societe dans la table de direction
        //int dirOk = MozartDatabase.ExecuteScalarInt($"SELECT count(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER ON D.NPERNUM = dbo.TPER.NPERNUM INNER JOIN " +
        //                                           $"TPER AS P ON dbo.TPER.VPERADSI = P.VPERADSI Where p.npernum = {MozartParams.UID}");
        int dirOk = MozartDatabase.ExecuteScalarInt($"SELECT COUNT(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER P ON D.NPERNUM = P.NPERNUM " +
                                                    $"WHERE P.NPERNUM = {MozartParams.UID}");

        if (dirOk == 1)
        {
          // on enregistre la validation et on valide la commande
          if (txtRmEng.Text != "")
          {
            if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ? \r\n Voulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          else
          {
            if (MessageBox.Show("Vous allez valider une commande de FO.\r\n Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }

          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QN{index}={MozartParams.UID}, DN{index}=GetDate() where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
          MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='V' where CCOMVALID<>'I' and NCOMNUM = {miNumCommande}");
          strStatutValidationCmd = "V";
          frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
          frameValidation.ForeColor = Color.Orange;
          lblPer5.Text = MozartParams.strUID;
          lblSign5.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
        }
        return;
      }

      //  CAS SPECIFICQUE FLUIDE FRIGO
      //   si index=6 (Service CVC)
      if (index == 6)
      {
        // test si personne a la droit (service CVC) menu 671
        if (ModuleMain.RechercheDroitMenu(671))
        {
          if (txtRmEng.Text != "")
          {
            if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ? \r\n Voulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          else
          {
            if (MessageBox.Show("Vous allez valider une commande de FO. \r\n Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }

          MozartDatabase.ExecuteNonQuery($"update TCOM_VALID_SPEC set DN_SPEC_1=GetDate(), QN_SPEC_1={MozartParams.UID} where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
          lblPer6.Text = MozartParams.strUID;
          lblSign6.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
          if (strStatutValidationCmd == "P") strStatutValidationCmd = "V";
        }
        return;
      }

      //  cas de l'edition de la commande
      if (index == 0)
      {
        if (strStatutValidationCmd != "V")
        {
          if (!(strStatutValidationCmd == "P" && IsValidCommandWithFluide(miNumCommande)))
            MessageBox.Show("La commande doit être validée avant de pouvoir l'éditer", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          using (SqlDataReader sdrDroitSpec = MozartDatabase.ExecuteReader($"EXEC [api_sp_Delegation_Spec_Detail] {miNumCommande}, 'CF'"))
          {
            if (sdrDroitSpec.Read())
            {
              //        '********************************************************************************************************
              //        'RETIRER DES COMMENTAIRES LE JOUR MIS EN PROD
              //        '#DEBUT04
              //        'test si droit valider
              /*
              if (Utils.BlankIfNull(sdrDroitSpec["DN_SPEC_1"]) == "")
              {
                MessageBox.Show("Vous ne pouvez pas editer cette commande car elle n' a pas été validé par le service CVC.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }*/
              //'        If BlankIfNull(adorsDroitSpec("DN_SPEC_1")) = "" Then
              //'            MsgBox "Vous ne pouvez pas editer cette commande car elle n' a pas été validé par le service CVC.", vbExclamation
              //'            Exit Sub
              //'        End If
              //        '#FIN04
              //        '********************************************************************************************************
            }
          }
          // on enregistre l'edition de la commande
          if (MessageBox.Show($"Vous allez valider l'édition de la commande de FO.{Environment.NewLine}Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set QEDIT={MozartParams.UID}, DEDIT=GetDate() where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
          MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='I' where NCOMNUM = {miNumCommande}");

          // droit spec
          MozartDatabase.ExecuteNonQuery($"update TCOM_VALID_SPEC set QEDIT_SPEC={MozartParams.UID}, DEDIT_SPEC=GetDate() where CTYPE='CF' AND NCOMNUM = {miNumCommande}");

          strStatutValidationCmd = "I";
          lblPer0.Text = MozartParams.strUID;
          lblSign0.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
          frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
          frameValidation.ForeColor = Color.Green;
          cmdVisu.Enabled = true;
          cmdImprimer.Enabled = true;
        }
      }

      //  cas des chef de Groupe
      //  BARBOSA, DALBEPIERRE, roussillion, VIGIEUR,  bouyssi, Dumont doivent se voir l'un l'autre.
      int[] ListeChefDeGroupe = { 226, 300, 1837, 1843, 3497, 3766, 4021, 4493, 3936, 622, 2066 };

      if (index == 3 && (Array.Exists(ListeChefDeGroupe, element => element == MozartParams.UID)))
      {
        if (Array.Exists(ListeChefDeGroupe, element => element == (int)lblSign3.Tag))
        {
          if (txtRmEng.Text != "")
          {
            if (MessageBox.Show($"Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?{Environment.NewLine}Voulez-vous toutefois valider ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          else
          {
            if (MessageBox.Show($"Vous allez valider une commande de FO.{Environment.NewLine}Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }
          // mise à jour de la validation
          lblPer3.Tag = ModuleMain.GetMontantSeuilByNPERNUM(MozartParams.UID);

          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN3=GetDate(), QN3={MozartParams.UID} where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
          lblSign3.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
          // si cela valide la commande, changer le statut dans la commande
          // on a ici le montant de l'engagement de la personne initiale (si Sylvie a droit à 10000 et que Elodie valide pour Sylvie, elle peut valider pour 10000)
          // il faudra peut être modifier cela pour prendre en compte les montants spécifiques de chaque personne.

          if (Convert.ToDouble(lblPer3.Tag) >= double.Parse(txtHT.Text, NumberStyles.Currency))
          {
            MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='V' where CCOMVALID<>'I' and NCOMNUM = {miNumCommande}");
            frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange;
            strStatutValidationCmd = "V"; // modif du 11/09/2019 par mc : suite a la demande de pierre, avant il faalait fermer la fenetre meme après une valition pour editer la commande
          }
          return;
        }
      }

      // cas 4  (chef de service)
      // VIGUIER et DUMONT  ... doivent se voir l'un l'autre.
      int[] ListeChefDeService = {1837, 4021};

      if (index == 4 && (Array.Exists(ListeChefDeService, element => element == MozartParams.UID)))
      {
        if (Array.Exists(ListeChefDeService, element => element == (int)lblSign4.Tag))   // ils ne peuvent valider que si c'est l'un d'eux en chef de groupe de ce contrat 
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
          lblPer4.Tag = ModuleMain.GetMontantSeuilByNPERNUM(MozartParams.UID);

          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN4=GetDate(), QN4={MozartParams.UID} where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
          lblSign4.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");

          // si cela valide la commande, changer le statut dans la commande
          if (Convert.ToDouble(lblPer4.Tag) >= double.Parse(txtHT.Text, NumberStyles.Currency))
          {
            MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='V' where CCOMVALID<>'I' and NCOMNUM = {miNumCommande}");
            frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange; // Orange
            strStatutValidationCmd = "V"; //modif du 11/09/2019 par mc : suite a la demande de pierre, avant il falait fermer la fenetre meme après une valition pour editer le contrat
          }
          return;
        }
      }

      //  cas 2,3,4,7
      if ((int)lblSign[index].Tag == MozartParams.UID)
      {
        if (txtRmEng.Text != "")
        {
          if (MessageBox.Show($"Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?{Environment.NewLine}Voulez-vous toutefois valider ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }
        else
        {
          if (MessageBox.Show($"Vous allez valider une commande de FO.{Environment.NewLine}Confirmer votre validation :", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }

        // mise a jour de la validation
        if (index == 7)
        {
          // Ce cas correspond au responsable adjoint (et donc sur DN6 ...)
          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN6=GetDate() where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
        }
        else
        {
          // Autres cas : 2,3,4
          MozartDatabase.ExecuteNonQuery($"update TCOMVALID set DN{index}=GetDate() where CTYPE='CF' AND NCOMNUM = {miNumCommande}");
        }
        lblSign[index].Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
        if (Convert.ToDouble(lblPer[index].Tag) >= double.Parse(txtHT.Text, NumberStyles.Currency))
        {
          MozartDatabase.ExecuteNonQuery($"update TCOM set CCOMVALID='V' where CCOMVALID<>'I' and NCOMNUM = {miNumCommande}");
          frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
          frameValidation.ForeColor = Color.Orange;
          strStatutValidationCmd = "V"; //modif du 11/09/2019 par mc : suite a la demande de pierre, avant il faalait fermer la fenetre meme après une valition pour editer la commande
        }
      }
    }

    public void EnregCommande(long numCom, DataRow row, long numstf = 0)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationCommande", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNumCommande"].Value = numCom;
          cmd.Parameters["@iNumFour"].Value = numstf == 0 ? (int)Utils.ZeroIfNull(row["NumSiteFour"]) : numstf; // on veut le site du fournisseur
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@nPrixHT"].Value = double.Parse(txtHT.Text, NumberStyles.Currency);
          cmd.Parameters["@nPrixTVA"].Value = double.Parse(txtTVA.Text, NumberStyles.Currency); // n'est pas utilisé dans le proc stock

          if (txtDateLiv.Text != "") cmd.Parameters["@dDateLiv"].Value = txtDateLiv.Text;

          cmd.Parameters["@typeL"].Value = ((cboItemType)cboType.SelectedItem).CODE;
          cmd.Parameters["@vRmq"].Value = txtRmq.Text;

          cmd.Parameters["@adresse1"].Value = Strings.Left(txtAdr1.Text, 50);
          cmd.Parameters["@adresse2"].Value = Strings.Left(txtAdr2.Text, 50);
          cmd.Parameters["@cp"].Value = txtCP.Text;
          cmd.Parameters["@ville"].Value = txtVille.Text.Trim();
          cmd.Parameters["@aattention"].Value = txtAttention.Text;
          cmd.Parameters["@lieulivr"].Value = txtLivr.Text;

          cmd.Parameters["@numArticle"].Value = (int)Utils.ZeroIfNull(row["NumArticle"]);
          cmd.Parameters["@qte"].Value = (int)Utils.ZeroIfNull(row["Quantite"]);

          double coef = 1.05; //valeur par défaut

          cmd.Parameters["@pu"].Value = numstf == 0 ? Convert.ToDouble(row["Prix U"]) : coef * Convert.ToDouble(row["Prix U"]); //coeff 1.05 pour ces commandes entre Emalec et les filiales
          cmd.Parameters["@pt"].Value = numstf == 0 ? Convert.ToDouble(row["Prix T"]) : coef * Convert.ToDouble(row["Prix T"]);

          if (txtDatePlanif.Text != "") cmd.Parameters["@dDatePlanif"].Value = txtDatePlanif.Text;

          if (lblFicChantier.Visible == true)
            cmd.Parameters["@nidfiche"].Value = (int)cboFicChantierFO.SelectedValue;
          else
            cmd.Parameters["@nidfiche"].Value = DBNull.Value;
          cmd.Parameters["@vComplInterim"].Value = TxtComplementInterimaire.Text;// NL, le 10/03/2017
          cmd.Parameters["@vRemInterne"].Value = TxtRemInterne.Text;
          cmd.Parameters["@bcomCHantier"].Value = chkChantier.Checked ? '1' : '0';
          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          miNumCom = (int)cmd.Parameters[0].Value;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ModificationCommande()
    {
      try
      {
        // delete des lignes de commandes dans la tables TLCO
        MozartDatabase.ExecuteNonQuery($"DELETE from TLCO where NCOMNUM = {miNumCommande}");

        // parcours du recordset et création des lignes articles
        foreach (DataRow row in dtArticle.Rows)
        {
          EnregCommande(miNumCommande, row);
        }

        // recherche si liste founrniture contient la série fluide frigo
        if (GetSerieFournitureByNCOMNUM(miNumCommande) == true)
          MozartDatabase.ExecuteNonQuery($"api_sp_Delegation_Spec_Save {miNumCommande}, 'CF'");

        // traitement de la delegation
        TraitementDelegation(miNumCommande);

        //  envoie mail si commande a destination du site (sephora)
        MozartDatabase.ExecuteNonQuery($"api_sp_SendMailExpeditionCF {miNumCommande}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AjouterEnrg(DataRow dr)
    {
      try
      {
        DataRow newrow = dtArticle.NewRow();

        newrow["Serie"] = Utils.BlankIfNull(dr["Serie"]);
        newrow["Article"] = Utils.BlankIfNull(dr["Article"]);
        newrow["Marque"] = Utils.BlankIfNull(dr["Marque"]);
        newrow["Type"] = Utils.BlankIfNull(dr["VFOUTYP"]);
        newrow["Reference"] = Utils.BlankIfNull(dr["VFOUREF"]);
        newrow["PCB"] = Utils.ZeroIfNull(dr["NFOUNBLOT"]);
        newrow["Prix U"] = Utils.ZeroIfNull(dr[3]);
        newrow["Quantite"] = Utils.ZeroIfNull(dr["Quantite"]);
        newrow["Prix T"] = Utils.ZeroIfNull(dr[5]);
        newrow["Fournisseur"] = Utils.BlankIfNull(dr["Fournisseur"]);
        newrow["NumArticle"] = Utils.ZeroIfNull(dr["NumArticle"]);
        newrow["NumFour"] = Utils.ZeroIfNull(dr["NumFour"]);
        newrow["NumSiteFour"] = Utils.ZeroIfNull(dr["NumSiteFour"]);

        dtArticle.Rows.Add(newrow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    void MajDtArticle2()
    {
      foreach (DataRow dr in dtArticle.Rows)
      {
        dr["Prix T"] = Utils.ZeroIfNull(dr["Prix U"]) * Utils.ZeroIfNull(dr["Quantite"]);
      }
    }

    class cboItemType
    {
      private char _code;
      private string _LIB;
      public cboItemType(char CODE, string LIB) { _code = CODE; _LIB = LIB; }
      public char CODE
      {
        get { return _code; }
      }
      public string LIB
      {
        get { return _LIB; }
      }
    }

    private void RemplirComboType()
    {
      cboType.Items.Clear();
      //  ' on gere le type de la commande avec des lettre
      //  ' E pour Emalec(idem pour fitelec)
      //  ' S pour Site
      //  ' T pour Technicien
      //  ' A pour Autre

      cboType.Items.Add(new cboItemType('E', MozartParams.NomSociete));
      cboType.Items.Add(new cboItemType('S', Resources.col_Site));
      cboType.Items.Add(new cboItemType('T', Resources.col_Technicien));
      cboType.Items.Add(new cboItemType('A', Resources.txt_autre));

      cboType.DisplayMember = "LIB";
      cboType.ValueMember = "CODE";
    }

    private void CreationCommandeEmalec()
    {
      try
      {
        miNumCom = 0;

        //parcours de la datatable et creation commande sur le fournisseur Emalec (937)
        foreach (DataRow row in dtArticle.Rows)
          EnregCommande(miNumCom, row, 937);

        // mise à jour dans l'obs de TACT
        MozartDatabase.ExecuteNonQuery($"api_sp_UpdateActionCom {miNumCom}, 'N', ''");

        // traitement delegation pouvoir
        TraitementDelegation(miNumCom);

        // si commande expédié directement au client pour une commande à EMALEC
        if (bCmdToSiteClient == true) MozartDatabase.ExecuteNonQuery($"api_sp_SaveCmdToCmdFromFiliale {miNumCom}, {MozartParams.NumAction}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboFicChantierFO_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (miNumCommande != 0 && bChargeCboFic)
        MozartDatabase.ExecuteNonQuery($"UPDATE TCOM SET NIDFICHE = {cboFicChantierFO.SelectedValue} WHERE NCOMNUM = {miNumCommande}");
    }

    private void txtRmEng_Enter(object sender, EventArgs e)
    {
      framObs.Visible = true;
      TxtObs.Focus();
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      // position en début de text quand focus et avec saut de ligne
      string temp = $"{MozartParams.strUID} le {DateTime.Now:dd/MM/yy HH:mm:ss} : ";
      string msg = TxtObs.Text;
      if (msg == "") return;

      if (txtRmEng.Text == "") txtRmEng.Text = temp + msg;
      else txtRmEng.Text = temp + msg + "\r\n" + txtRmEng.Text;

      // enregistrement dans la base
      MozartDatabase.ExecuteNonQuery($"update TCOMVALID set VRMQ='{txtRmEng.Text.Replace("'", "''")}' where CTYPE='CF' AND NCOMNUM = {miNumCommande}");

      //enregistrement dans la base
      MozartDatabase.ExecuteNonQuery($"update TCOM_VALID_SPEC set VRMQ_SPEC='{txtRmEng.Text.Replace("'", "''")}' where CTYPE='CF' AND NCOMNUM = {miNumCommande}");

      // envoi du mail au créateur d'une saisie de remarque
      if (msg != "") MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_EnvoiMsgDelegationAddObs] {miNumCommande}, 'COM'");

      // on vide le champ temporaire
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private void CmdAnaChantier_Click(object sender, EventArgs e)
    {
      if (cboFicChantierFO.SelectedIndex == 0)
      {
        MessageBox.Show(Resources.msg_selectFiche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"SELECT TCHANTIERFICHE.NIDCHANTIER FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDFICHE = {cboFicChantierFO.SelectedValue}"))
      {
        if (sdr.Read())
        {
          new frmXListeWithChiffrage("CHANTIER", sdr["NIDCHANTIER"]).ShowDialog();
        }
      }
    }

    public int IsCommandeReapproFillialeAuto(int NACTNUM)
    {
      using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetNDDEDEST_NDDENUM_EMALEC_By_NACTNUM] {NACTNUM}"))
      {
        if (!sdr.Read())
        {
          return 0;
        }

        return (int)Utils.ZeroIfNull(sdr["NDDEDEST"]);
      }
    }

    public bool GetSerieFournitureByNCOMNUM(long iNCOMNUM)
    {
      try
      {
        int count = (int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(*) FROM TLCO INNER JOIN TFOU ON TFOU.NFOUNUM = TLCO.NFOUNUM AND TFOU.NCFOCOD = 56 WHERE NCOMNUM = {iNCOMNUM}");
        if (Utils.ZeroIfNull(count) > 0) return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    public bool FouProduitDangerExist(string sType, long lID)
    {
      if (sType != "TSTOCKDDE" && sType != "TCOM")
      {
        MessageBox.Show("Mod Main: FouProduitDangerExist() - Type non reconnu", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }

      using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"EXEC api_sp_FouFicheProdDangerExist '{sType}',{lID}"))
      {
        if (sdr.Read() && (int)Utils.ZeroIfNull(sdr["NB"]) > 0)
          return true;
      }
      return false;
    }

    public string GetLangueByNSTFNUM(long p_NSTFNUM)
    {
      using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetLangueByNSTFNUM] {p_NSTFNUM}"))
      {
        if (sdr.Read()) return Utils.BlankIfNull(sdr[0]);
      }
      return "FR";
    }


    public bool IsValidCommandWithFluide(long iNCOMNUM)
    {
      try
      {
        int count = MozartDatabase.ExecuteScalarInt($"SELECT COUNT(*) FROM TCOM_VALID_SPEC WHERE CTYPE = 'CF' AND DN_SPEC_1 IS NOT NULL AND NCOMNUM = {iNCOMNUM}");
        if (Utils.ZeroIfNull(count) > 0) return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {

      // FGA le 02/03/2022  demande de Pierre
      // ce bouton permet d'enregistrer des remarques internes même si la commande ne peut plus être modifiée car elle a déjà les validations hiérachiques
      if (miNumCommande == 0) return;

      // enregistrement dans la base
      MozartDatabase.ExecuteNonQuery($"update TCOM set VCOMREM_INTERNE='{TxtRemInterne.Text.Replace("'", "''")}' where NCOMNUM = {miNumCommande}");

    }

    private void cboTech_SelectedIndexChanged(object sender, EventArgs e)
    {

      if (cboTech.Text == "") return;
      if (cboTech.Text.IndexOf(".") == -1) return;
      txtAttention.Text = $"{cboTech.Text.Substring(cboTech.Text.IndexOf(".") + 1, cboTech.Text.IndexOf(":") - cboTech.Text.IndexOf(".") - 2)} {cboTech.Text.Substring(0, 1)} {cboTech.Text.Substring(cboTech.Text.IndexOf(":"))}";
    }

    private void enregDateLivr_Click(object sender, EventArgs e)
    {
      if (miNumCommande == 0) return;

      // enregistrement dans la base
      if (txtDateLiv.Text != "")
      {
        MozartDatabase.ExecuteNonQuery($"update TCOM set DCOMDLI='{txtDateLiv.Text}' where NCOMNUM = {miNumCommande}");
      }
    }
  }
}
