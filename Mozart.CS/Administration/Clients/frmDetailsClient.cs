using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmDetailsClient : Form
  {
    // Normalement la création d'un client (miNumClient = 0 et mstrStatut = "C" passe le wizard de création client
    public int miNumClient = 0;
    public string mstrStatut = "";

    private bool mbModif = false;
    private bool bAccesResp = false;
    private bool mbInit = false;
    private long iIDPROCEI;


    private class ListPrestationItemData
    {
      public string VPRELIB;
      public char CPRECOD;
      public override string ToString()
      {
        return VPRELIB;
      }
    }

    public frmDetailsClient()
    {
      InitializeComponent();
    }

    private void frmDetailsClient_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        iIDPROCEI = 0;
        mbInit = true;

        RemplirComboLangues();

        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        //'modif mc le 20/06/2017 ala demande de jj ajouter les tech : CPERTYP <> 'TE'
        ModuleData.RemplirCombo(cboCommercial, $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS NOM from TPER WHERE CPERACTIF = 'O' AND CPERTYP <> 'TE' AND VSOCIETE = '{MozartParams.NomSociete}' order by VPERNOM + ' ' + VPERPRE", false);
        cboCommercial.ValueMember = "NPERNUM";
        cboCommercial.DisplayMember = "NOM";

        ModuleData.RemplirCombo(cboTechnico, $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS NOM from TPER WHERE NSERNUM = 11 AND CPERACTIF = 'O' AND VSOCIETE = '{MozartParams.NomSociete}' order by VPERNOM + ' ' + VPERPRE");
        cboTechnico.ValueMember = "NPERNUM";
        cboTechnico.DisplayMember = "NOM";

        //13/12/2016, ajout combo pour Emalec Habitat
        ModuleData.RemplirCombo(cboClientEH, $"select CREFPROVCLIENTEH, LIBELLE from TREF_PROV_CLIENT_EH WHERE LANGUE = '{MozartParams.Langue}' order by LIBELLE", false);
        cboClientEH.ValueMember = "CREFPROVCLIENTEH";
        cboClientEH.DisplayMember = "LIBELLE";
        cboClientEH.SelectedIndex = -1;

        chkAttachMarchPublic.Text += " " + MozartParams.NomSociete;

        // Combo GMAO utilisée par le client
        ModuleData.RemplirCombo(cboUsedGMAO, "SELECT ID, LIBELLE from TREF_GMAO ORDER BY ID", true);
        cboUsedGMAO.ValueMember = "ID";
        cboUsedGMAO.DisplayMember = "LIBELLE";
        cboUsedGMAO.SelectedIndex = 0;

        // Combo Saisie sur GMAO client
        initComboOuiNon(cboSaisieSurGMAO);

        // Combo Saisie sur GMAO client
        initComboOuiNon(cboExistPasserelleMozaris);

        //traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        //on récupere le nidproc
        iIDPROCEI = (long)Utils.ZeroIfNull(MozartDatabase.ExecuteScalarInt("SELECT TOP 1 NIDPROC FROM TPROCEDURE WITH(NOLOCK) WHERE NCLINUM = " + miNumClient + " AND BPROCACTIF = 1 AND NIDTYPPROC = 15 ORDER BY DATECRE DESC"));
        if (iIDPROCEI > 0)
          cmdCreateContEI.BackColor = Color.FromArgb(251, 255, 83);

        //droit sur le bouton en fonction de perimetre lié a son statut
        //BtnContrat.Visible = false;


        mbInit = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void initComboOuiNon(ComboBox pComboBox)
    {
      pComboBox.Items.Clear();
      pComboBox.Items.Add(MZCtrlResources.oui);
      pComboBox.Items.Add(MZCtrlResources.non);
      pComboBox.SelectedIndex = pComboBox.Items.Count - 1;
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      try
      {
        if (mbModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              cmdEnregistrer_Click(null, null);
              break;
            case DialogResult.Cancel:
              return;
          }
        }
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        //test du nom
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNom.Focus();
          return;
        }
        //recherche si le nom du client n'est pas un doublon (si on modifie)
        if (NomExist(txtNom.Text))
        {
          MessageBox.Show(Resources.msg_must_type_client_exists, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNom.Focus();
          return;
        }
        //test de la sélection d'un pays
        if (cboPays.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_pays, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        //langue d'édition des factures
        if (cboLangue.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_langue, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboPays.Text == "FRANCE")
        {
          //test de la sélection d'une ville
          if (cboVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        else
        {
          if (txtVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        if (txtCliActivite.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_activite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboCommercial.Text == "")
        {
          MessageBox.Show("Choisissez obligatoirement un commercial pour ce client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (!chkTypoPro.Checked && !chkTypoPart.Checked)
        {
          MessageBox.Show("Choisissez obligatoirement une typologie pour ce client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdEnregistrer.Tag.ToString(), "Modification", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);
        Enregistrer();

        // on passe la feuille en statut 'Modifié'
        mstrStatut = "M";

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAnaGidtCli_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAnaGidtCli.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);
      new frmAnaGidtCli { miNumClient = miNumClient }.ShowDialog();
    }

    private void cboLangue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
    }

    private void RemplirComboLangues()
    {
      DataTable dt = new DataTable();
      try
      {
        var dataReader = MozartDatabase.ExecuteReader("SELECT DISTINCT VLANGUEDEFAUT, VLANGUEABR FROM TPAYS ORDER BY VLANGUEDEFAUT");
        dt.Load(dataReader);
        dataReader.Close();

        foreach (DataRow row in dt.Rows)
        {
          cboLangue.Items.Add(row[0].ToString());
          cboLangueAbrev.Items.Add(row[1].ToString());
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkCompteur_Click(object sender, EventArgs e)
    {
      if (mbInit)
        return;
      MessageBox.Show("Gestion des compteurs : " + "\r\n" + "Les sites vont recevoir un mail en début de mois pour leur demander de saisir les compteurs sur le web." + "\r\n" + "Pour la création des compteurs, voir avec le service informatique EMALEC.");
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmRechCodePostal { ControlCible1 = txtCP, ControlCible2 = cboVille }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void OuvertureEnCreation()
    {
      try
      {
        cboPays.Text = "France";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      bool verifProfil = false;

      try
      {
        string sSQL = $"select * from TCLI WHERE NCLINUM = {miNumClient}";

        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            txtNom.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtAD1.Text = Utils.BlankIfNull(sdr["VCLIAD1"]);
            txtAD2.Text = Utils.BlankIfNull(sdr["VCLIAD2"]);
            txtCP.Text = Utils.BlankIfNull(sdr["VCLICP"]);
            txtVille.Text = Utils.BlankIfNull(sdr["VCLIVIL"]);
            txtCedex.Text = Utils.BlankIfNull(sdr["VCLICEDEX"]);
            txtCPCedex.Text = Utils.BlankIfNull(sdr["VCLICPCEDEX"]);
            txtCedex.Text = Utils.BlankIfNull(sdr["VCLICEDEX"]);
            txtAuto.Text = Utils.BlankIfNull(sdr["NCLIAUTOSTOCK"]);
            txtObs.Text = Utils.BlankIfNull(sdr["VCLIMESS"]);
            txtInfoFacturation.Text = Utils.BlankIfNull(sdr["VCLIOBS"]);
            txtInfosPlanif.Text = Utils.BlankIfNull(sdr["VCLIINFOSPLANIF"]);
            txtDate.Text = Utils.DateLongBlankIfNull(sdr["DCLIDATECRE"]);
            txtCodeAPE.Text = Utils.BlankIfNull(sdr["VCLICODEAPE"]);
            optFac0.Checked = Utils.BlankIfNull(sdr["VCLITYPEFAC"]) == "M";  // multitech
            optFac1.Checked = Utils.BlankIfNull(sdr["VCLITYPEFAC"]) == "R";  // regie
            optFac2.Checked = Utils.BlankIfNull(sdr["VCLITYPEFAC"]) == "F";  // fournitures sur multitech
            optFac3.Checked = Utils.BlankIfNull(sdr["VCLITYPEFAC"]) == "D";  // fournitures sur régies
            optFac4.Checked = Utils.BlankIfNull(sdr["VCLITYPEFAC"]) == "O";  // Forfait MO/Dépl et détail des fournitures
            optRes0.Checked = Utils.BlankIfNull(sdr["CCLICHOIXRES"]) == "S";  // site
            optRes1.Checked = Utils.BlankIfNull(sdr["CCLICHOIXRES"]) == "D";  // DI
            chkTypeClient.Checked = Utils.BlankIfNull(sdr["CCLITYPE"]) == "I";  // type client inventaire a réaliser
            chkAccWeb.Checked = Utils.BlankIfNull(sdr["CCLIACCWEBRESP"]) == "O";
            chkClientColis.Checked = Utils.BlankIfNull(sdr["CEMALECHABITAT"]) == "O";  // FGA le 03/06/2024 réutilisation d'un champ existant
            chkGestNumero.Checked = Convert.ToBoolean(sdr["BCLIGESTNUM"]);
            chkCompteur.Checked = Convert.ToBoolean(sdr["BCLIGESTCPTEUR"]);
            chkFormationEI0.Checked = Convert.ToInt32(sdr["BCLIFORMEI"]) == 1;
            chkFormationEI1.Checked = Convert.ToInt32(sdr["BCLIFORMEI"]) == 2;
            chkEIFactDifferee.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BEIFACTDIFFEREE"]));
            chkCliRapportFM.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BCLIRAPPORTFM"]));
            chkAttachMarchPublic.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BATTACHMARCHPUBLIC"]));
            ChkPDP_Action.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BCLI_PDP_ACTION"]));
            chkRelance.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BCLIRELANCEIMPAYE"]));
            chkP3.Checked = Utils.BlankIfNull(sdr["CCLIP3"]) == "O";
            ChkHrArrExeAttach.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BCLI_ATTACH_HR_ARR_EXE"]));
            ChkNumCdeUniqueDi.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BCLI_NUMCDE_DI"]));

            //typologie
            switch (Utils.ZeroIfNull(sdr["NCLITYPOLOGIE"]))
            {
              case 1: //particulier
                chkTypoPart.Checked = true;
                break;
              case 2: //professionel
                chkTypoPro.Checked = true;
                break;
            }

            bAccesResp = (Utils.BlankIfNull(sdr["CCLIACCWEBRESP"]) == "O");

            // combo de la ville
            cboVille.Text = Utils.BlankIfNull(sdr["VCLIVIL"]);
            if (cboVille.Text == "")
            {
              cboVille.Items.Add(sdr["VCLIVIL"]);
              cboVille.Text = Utils.BlankIfNull(sdr["VCLIVIL"]);
            }

            // combo du pays
            cboPays.Text = Utils.BlankIfNull(sdr["VCLIPAYS"]);
            if (Utils.BlankIfNull(sdr["VCLIPAYS"]) != "" && cboPays.Text == "")
            {
              DataTable dt = cboPays.DataSource as DataTable;
              DataRow row = dt.NewRow();
              row[1] = Utils.BlankIfNull(sdr["VCLIPAYS"]);
              dt.Rows.Add(row);
              cboPays.Text = Utils.BlankIfNull(sdr["VCLIPAYS"]);
            }

            // combo de la langue (04/04/2016)
            cboLangueAbrev.Text = Utils.BlankIfNull(sdr["VCLILANGUE"]) == "" ? "FR" : sdr["VCLILANGUE"].ToString();
            cboLangue.SelectedIndex = cboLangueAbrev.SelectedIndex;

            // Activité
            txtCliActivite.Text = Utils.BlankIfNull(sdr["VCLIACTIVITE"]);

            //  Type Client (EI , EH), NL le 02/02/2017
            cboTypeClient.Text = Utils.BlankIfNull(sdr["VTYPECLIENT"]) == "EH" ? "" : sdr["VTYPECLIENT"].ToString();

            cboUsedGMAO.SetItemData(Utils.BlankIfNull(sdr["NID_GMAO"]));
            cboSaisieSurGMAO.SelectedIndex = Convert.ToInt32(sdr["NSAISIE_GMAO"]);
            cboExistPasserelleMozaris.SelectedIndex = Convert.ToInt32(sdr["NEXIST_PASSERELLE_MOZARIS"]);
          }
        }

        //on verifie si le profil du responsable est créé pour mettre le bouton en couleur
        if (bAccesResp)
        {
          int iDroitWeb = MozartDatabase.ExecuteScalarInt("SELECT COUNT(*) FROM TDROITWEB WHERE VUTILOG = '-Responsable-' AND CDROITVAL = 'O' AND NCLINUM = " + miNumClient);
          if (iDroitWeb > 0)
          {
            verifProfil = true;
            cmdProfil.BackColor = Color.FromArgb(251, 255, 83);
            cmdProfil.Tag = iDroitWeb;
          }
        }

        if (verifProfil)
        {
          sSQL = "SELECT TOP 1 VUTIDROIT, NUTIMTVAL FROM TUTI WHERE CUTITYPE = 'R' AND CUTICAT = 'C' AND NUTINUM = " + miNumClient;
          using (SqlDataReader sdrProfil = MozartDatabase.ExecuteReader(sSQL))
          {
            if (sdrProfil.Read())
            {
              cboDroit.Text = sdrProfil["VUTIDROIT"].ToString();
              txtValid.Text = sdrProfil["NUTIMTVAL"].ToString();
            }
            else
              MessageBox.Show(Resources.msg_no_webaccess, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        // Contact commercial
        sSQL = "SELECT NPERNUM, NTECHNICONUM FROM TCLIPER WHERE TCLIPER.NCLINUM = " + miNumClient;
        using (SqlDataReader sdrCommercial = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdrCommercial.Read())
          {
            if (sdrCommercial["NPERNUM"] != DBNull.Value) cboCommercial.SetItemData(sdrCommercial["NPERNUM"].ToString());
            if (cboCommercial.SelectedItem == null)
            {
              cboCommercial.SetItemData("0");
            }
            if (sdrCommercial["NTECHNICONUM"] != DBNull.Value) cboTechnico.SetItemData(sdrCommercial["NTECHNICONUM"].ToString());
            if (cboTechnico.SelectedItem == null)
            {
              cboTechnico.SetItemData("0");
            }
          }
        }

        sSQL = "select * from TCLIHAB WHERE NCLINUM = " + miNumClient;
        using (SqlDataReader sdrHab = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdrHab.Read())
            if (sdrHab["CREFPROVCLIENTEH"] != DBNull.Value) cboClientEH.SetItemData(sdrHab["CREFPROVCLIENTEH"].ToString());
        }

        // Affichage des infos de la période de référence (Contrat préventif)
        sSQL = $"SELECT NNUMPER, CONVERT(VARCHAR(10), DDATEDEBUT, 103) AS DDATEDEBUT, CONVERT(VARCHAR(10), DDATEFIN, 103) AS DDATEFIN, VTREFLIB, NTOTPREV";
        sSQL += $" FROM TCONTRATPER INNER JOIN TREF_TYPFACT ON TCONTRATPER.NTYPFACT = TREF_TYPFACT.NTREF_TYPFACT";
        sSQL += $" WHERE CCONTRATPERACTIF = 'O' AND GETDATE() BETWEEN DDATEDEBUT AND DDATEFIN AND NCLINUM = {miNumClient}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
        {
          if (sdr.Read())
          {
            double lTotPrevSeul;

            txtTypeFact.Text = Utils.BlankIfNull(sdr["VTREFLIB"]);
            txtDateDebCtPrev.Text = Utils.BlankIfNull(sdr["DDATEDEBUT"]);
            txtDateFinCtPrev.Text = Utils.BlankIfNull(sdr["DDATEFIN"]);
            lTotPrevSeul = Utils.ZeroIfNull(sdr["NTOTPREV"]);
            txtTotPrevSeul.Text = lTotPrevSeul.ToString();

            fillFrameContratPrev();
          }
        }

        mbModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void fillFrameContratPrev()
    {
      string sSQL;
      double lTotContratFact;
      double lTotFactMan;
      double lTotCurFourSeul;
      double lTotPrevSeul;
      double lRatio;
      int lNumPer;

      // Affichage des infos de la période de référence (Contrat préventif)
      sSQL = $"SELECT NNUMPER, CONVERT(VARCHAR(10), DDATEDEBUT, 103) AS DDATEDEBUT, CONVERT(VARCHAR(10), DDATEFIN, 103) AS DDATEFIN, VTREFLIB, NTOTPREV, NTOTFACTMAN";
      sSQL += $" FROM TCONTRATPER INNER JOIN TREF_TYPFACT ON TCONTRATPER.NTYPFACT = TREF_TYPFACT.NTREF_TYPFACT";
      sSQL += $" WHERE CCONTRATPERACTIF = 'O' AND GETDATE() BETWEEN DDATEDEBUT AND DDATEFIN AND NCLINUM = {miNumClient}";
      using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
      {
        if (sdr.Read())
        {

          txtTypeFact.Text = Utils.BlankIfNull(sdr["VTREFLIB"]);
          txtDateDebCtPrev.Text = Utils.BlankIfNull(sdr["DDATEDEBUT"]);
          txtDateFinCtPrev.Text = Utils.BlankIfNull(sdr["DDATEFIN"]);
          lTotPrevSeul = Utils.ZeroIfNull(sdr["NTOTPREV"]);
          txtTotPrevSeul.Text = lTotPrevSeul.ToString();
          lTotFactMan = Utils.ZeroIfNull(sdr["NTOTFACTMAN"]);
          txtTotFactMan.Text = lTotFactMan.ToString();

          lNumPer = Convert.ToInt32(Utils.ZeroIfNull(sdr["NNUMPER"]));

          // Remplissage Tot prev seul remontée DI
          sSQL = "SELECT ISNULL(SUM(NACTVAL), 0) FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM";
          sSQL += " INNER JOIN TCONTRATPER ON TCONTRATPER.NCLINUM = TDIN.NCLINUM AND TCONTRATPER.NCONTRATPERNUM = TDIN.NCONTRATPERNUM";
          sSQL += " WHERE CPRECOD = 'P' AND TDIN.NTYPECONTRAT <> 475"; // Contrat FACTURATION
          sSQL += $" AND TDIN.NCLINUM = {miNumClient} AND TCONTRATPER.NNUMPER = {lNumPer}";
          double lTTotPrevSeulRemonteeDI = (double)Utils.ZeroIfNull(ModuleData.ExecuteScalarDouble(sSQL));
          txtTotPrevSeulRemonteeDI.Text = lTTotPrevSeulRemonteeDI.ToString();

          // Remplissage Tot contrat facturation
          sSQL = "SELECT ISNULL(SUM(NACTVAL), 0) FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM";
          sSQL += " INNER JOIN TCONTRATPER ON TCONTRATPER.NCLINUM = TDIN.NCLINUM AND TCONTRATPER.NCONTRATPERNUM = TDIN.NCONTRATPERNUM";
          sSQL += $" WHERE CPRECOD = 'P' AND TDIN.NTYPECONTRAT = 475 AND TDIN.NCLINUM = {miNumClient} AND TCONTRATPER.NNUMPER = {lNumPer}";
          lTotContratFact = (double)ModuleData.ExecuteScalarDouble(sSQL);
          txtTotContratFact.Text = lTotContratFact.ToString();

          // Calcul tot cur fourn seul
          lTotCurFourSeul = lTotFactMan - lTotPrevSeul;
          txtTotCurFourSeul.Text = lTotCurFourSeul.ToString();
          // Ratio
          lRatio = (lTotFactMan == 0.0) ? 0.0 : lTotPrevSeul / lTotFactMan;
          txtRatio.Text = lRatio.ToString();
        }
      }
    }

    private void Enregistrer()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationClient", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@vNom"].Value = txtNom.Text.ToUpper();

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vCedex"].Value = txtCedex.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vCpCedex"].Value = txtCPCedex.Text == "" ? DBNull.Value : (object)txtCPCedex.Text;
          cmd.Parameters["@vCedex"].Value = txtCedex.Text == "" ? DBNull.Value : (object)txtCedex.Text;
          cmd.Parameters["@nStock"].Value = (Utils.ZeroIfNull(txtAuto.Text) == 0) ? 2 : Convert.ToInt32(txtAuto.Text);
          cmd.Parameters["@vObs"].Value = txtObs.Text;

          if (optFac0.Checked)
            cmd.Parameters["@vtypeFac"].Value = "M";
          else if (optFac1.Checked)
            cmd.Parameters["@vtypeFac"].Value = "R";
          else if (optFac2.Checked)
            cmd.Parameters["@vtypeFac"].Value = "F";
          else if (optFac3.Checked)
            cmd.Parameters["@vtypeFac"].Value = "D";
          else if (optFac4.Checked)
            cmd.Parameters["@vtypeFac"].Value = "O";

          cmd.Parameters["@vChoixRes"].Value = (optRes0.Checked) ? "S" : "D";
          cmd.Parameters["@vInfoFact"].Value = txtInfoFacturation.Text;
          cmd.Parameters["@vTypeCli"].Value = chkTypeClient.Checked ? "I" : "";
          cmd.Parameters["@bGestNumero"].Value = chkGestNumero.Checked ? 1 : 0;
          cmd.Parameters["@npernumcom"].Value = cboCommercial.GetItemData();
          cmd.Parameters["@nTechnico"].Value = cboTechnico.GetItemData();
          cmd.Parameters["@cAccWeb"].Value = chkAccWeb.Checked ? "O" : "N";
          cmd.Parameters["@cEMALECHABITAT"].Value = chkClientColis.Checked ? "O" : "N";
          cmd.Parameters["@vTypeClient"].Value = cboTypeClient.Text == "EI" ? "EI" : "";
          cmd.Parameters["@cCpteur"].Value = chkCompteur.Checked ? 1 : 0;
          cmd.Parameters["@vCliActivite"].Value = txtCliActivite.Text;

          //  '-- code 1 si coche formation EI, code 0 si pas de coche, code 2 si PMR en plus
          cmd.Parameters["@bCliFormEI"].Value = chkFormationEI0.Checked ? 1 : (chkFormationEI1.Checked) ? 2 : 0;
          cmd.Parameters["@bEIFactDifferee"].Value = chkEIFactDifferee.Checked ? 1 : 0;
          cmd.Parameters["@vInfosPlanif"].Value = txtInfosPlanif.Text;
          cmd.Parameters["@bRapportFM"].Value = chkCliRapportFM.Checked ? 1 : 0;
          cmd.Parameters["@BATTACHMARCHPUBLIC"].Value = chkAttachMarchPublic.Checked ? 1 : 0;
          cmd.Parameters["@vlangueabr"].Value = cboLangueAbrev.Text;
          cmd.Parameters["@VCODEAPE"].Value = txtCodeAPE.Text;
          cmd.Parameters["@NCLITYPOLOGIE"].Value = chkTypoPart.Checked ? 1 : 2;
          cmd.Parameters["@BCLI_PDP_ACTION"].Value = ChkPDP_Action.Checked ? 1 : 0;
          cmd.Parameters["@BCLI_RELANCE_IMP"].Value = chkRelance.Checked ? 1 : 0;
          cmd.Parameters["@BCLI_ATTACH_HR_ARR_EXE"].Value = ChkHrArrExeAttach.Checked ? 1 : 0;
          cmd.Parameters["@BCLI_NUMCDE_DI"].Value = ChkNumCdeUniqueDi.Checked ? 1 : 0;
          cmd.Parameters["@cContratP3"].Value = chkP3.Checked ? "O" : "N";

          cmd.Parameters["@nUsedGMAO"].Value = cboUsedGMAO.GetItemData();
          cmd.Parameters["@nSaisieSurGMAO"].Value = cboSaisieSurGMAO.SelectedIndex;
          cmd.Parameters["@nExistPasserelleMozaris"].Value = cboExistPasserelleMozaris.SelectedIndex;

          cmd.ExecuteNonQuery();

          //  récupération du numéro crée
          miNumClient = (int)cmd.Parameters[0].Value;
        }

        // Si on a décoché les accès par resp site, alors on supprime le profil existant
        if (!chkAccWeb.Checked && bAccesResp)
        {
          if (MessageBox.Show(Resources.msg_confirm_deletion_webaccess, Program.AppTitle,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            // Suppression des accès web des responsable site + profil créé
            MozartDatabase.ExecuteNonQuery($"DELETE TDROITWEB WHERE NCLINUM = {miNumClient} AND VUTILOG IN (SELECT VUTILOG FROM TUTI WHERE CUTITYPE = 'R' AND  NUTINUM = {miNumClient})");
            MozartDatabase.ExecuteNonQuery($"DELETE TACCESWEB WHERE CUTITYPE = 'R' AND NUTINUM =  {miNumClient}");
            MozartDatabase.ExecuteNonQuery($"DELETE TUTI WHERE CUTITYPE = 'R' AND NUTINUM =  {miNumClient}");

            MozartDatabase.ExecuteNonQuery($"DELETE TACCESWEB WHERE CUTICAT = 'P' AND NUTINUM = {miNumClient}");
            MozartDatabase.ExecuteNonQuery($"DELETE TUTI WHERE CUTICAT = 'P' AND NUTINUM = {miNumClient}");
            MozartDatabase.ExecuteNonQuery($"DELETE TDROITWEB WHERE VUTILOG = '-Responsable-' AND NCLINUM = {miNumClient}");
          }
          else
            chkAccWeb.Checked = bAccesResp;
        }

        //  ' on met a jour les profil responsable avec les valeurs saisies
        MozartDatabase.ExecuteNonQuery($"UPDATE TUTI SET VUTIDROIT = '{(Utils.BlankIfNull(cboDroit.SelectedValue) == "" ? "OUI" : cboDroit.SelectedValue)}', " +
                                   $"NUTIMTVAL = {Utils.ZeroIfNull(txtValid.Text)} WHERE CUTITYPE = 'R' AND NUTINUM = {miNumClient}");
        MozartDatabase.ExecuteNonQuery($"UPDATE TACCESWEB SET VUTIDROIT = '{(Utils.BlankIfNull(cboDroit.SelectedValue) == "" ? "OUI" : cboDroit.SelectedValue)}', " +
                                   $"NUTIMTVAL = {Utils.ZeroIfNull(txtValid.Text)} WHERE CUTITYPE = 'R' AND NUTINUM = {miNumClient}");
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cboPays_Click(object sender, EventArgs e)
    {
      cboVille.Visible = cmdRecherche.Visible = (cboPays.Text == "France");
      txtVille.Visible = !cboVille.Visible;
    }

    private void cmdAide_Click(object sender, EventArgs e)
    {
      string sChaine = "Langue d'édition des devis client.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void frmDetailsClient_KeyPress(object sender, KeyPressEventArgs e)
    {
      mbModif = true;
    }

    private void frmDetailsClient_FormClosing(object sender, FormClosingEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void options_CheckedChanged(object sender, EventArgs e)
    {
      mbModif = true;
    }

    private void txtCliActivite_TextChanged(object sender, EventArgs e)
    {
      int iPos = txtCliActivite.SelectionStart;
      txtCliActivite.Text = txtCliActivite.Text.ToUpper();
      txtCliActivite.SelectionStart = iPos;
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length == 5 && cboPays.Text == "FRANCE")
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }

    private void txtCPCedex_Leave(object sender, EventArgs e)
    {
      if (txtCPCedex.Text != "" && txtCedex.Text == "")
        txtCedex.Text = "CEDEX";
    }

    private void txtCedex_Leave(object sender, EventArgs e)
    {
      txtCedex.Text = txtCedex.Text.ToUpper();
    }

    private void txtAuto_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private bool NomExist(string nom)
    {
      int iNb = MozartDatabase.ExecuteScalarInt($"SELECT count(*) from TCLI WHERE NCLINUM <> {miNumClient} AND UPPER(VCLINOM) = '{txtNom.Text.ToUpper().Replace("'", "''")}' AND VSOCIETE = APP_NAME()");
      return (iNb > 0);
    }

    private void ChkFormationEI0_CheckedChanged(object sender, EventArgs e)
    {
      if (chkFormationEI0.Checked)
        chkFormationEI1.Checked = false;
    }
    private void ChkFormationEI1_CheckedChanged(object sender, EventArgs e)
    {
      if (chkFormationEI1.Checked)
        chkFormationEI0.Checked = false;
    }

    private void chkAccWeb_CheckedChanged(object sender, EventArgs e)
    {
      int iLogin = 0;
      cmdProfil.Visible = cmdEnvoiMail.Visible = cboDroit.Visible = txtValid.Visible = Label0.Visible = Label2.Visible = chkAccWeb.Checked;

      cboDroit.Text = "OUI";
      txtValid.Text = "300";

      // si la case est cochée et que son état a changé, on crée le profil resp
      if (!mbInit && chkAccWeb.Checked && (chkAccWeb.Checked) != bAccesResp)
      {
        //   création de l'accès web
        //   création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAccesWeb", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iLogin"].Value = 0;
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@vNom"].Value = "-Responsable-";
          cmd.Parameters["@vPwd"].Value = "";
          cmd.Parameters["@cCat"].Value = "P";
          cmd.Parameters["@cDroit"].Value = "NON";
          cmd.Parameters["@iValidation"].Value = 0;
          cmd.Parameters["@cTyp"].Value = "P";
          cmd.Parameters["@bCrt"].Value = false;
          cmd.Parameters["@bLogin"].Value = false;

          cmd.ExecuteNonQuery();

          //  récupération du numéro créé
          iLogin = (int)cmd.Parameters[0].Value;
        }
        MozartDatabase.ExecuteNonQuery($"EXEC api_sp_CreationLigneAccesweb  '-Responsable-', '', 'P', {miNumClient}, 0,'NON',0 ,'P', {iLogin}");

        // creation des menus à NON
        MozartDatabase.ExecuteNonQuery($"INSERT INTO TDROITWEB SELECT '-Responsable-','P', {miNumClient}, NMENUNUM,'N' FROM TMENUWEB WHERE NMENUNUM < 1000");

        bAccesResp = true;
        Enregistrer();
      }
    }

    private void cmdProfil_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      CreationAccesResp();
      Cursor.Current = Cursors.Default;

      if (MessageBox.Show("Attention, après avoir défini le profil web de référence, les accès des sites seront créés ou modifiés avec ce profil.\r\nVoulez-vous continuer ?", Program.AppTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        Cursor.Current = Cursors.WaitCursor;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdProfil.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient.ToString(), "VCLINOM:" + txtNom.Text);

        new frmGestionMenuWeb { miNumClient = (int)miNumClient, mstrType = "P" }.ShowDialog();

        Cursor.Current = Cursors.Default;
      }
    }

    private void CreationAccesResp()
    {
      try
      {
        //  si au moins un menu a été coché alors on crée les profil des resp site
        string sSQL = $"SELECT COUNT(*) FROM TDROITWEB WHERE VUTILOG = '-Responsable-' AND CDROITVAL = 'O' AND CUTICAT = 'P' AND  NCLINUM = {miNumClient}";
        if (MozartDatabase.ExecuteScalarInt(sSQL) > 0)
        {
          sSQL = "SELECT DISTINCT TSIT.NSITNUM, NSITNUE FROM TSIT INNER JOIN TCSIT ON TCSIT.NSITNUM = TSIT.NSITNUM" +
                 $" WHERE TCSIT.NTYPCSITNUM = 1 AND VCSITMAI <> '' AND TSIT.NCLINUM = {miNumClient} AND CSITACTIF = 'O' ";
          using (SqlDataReader sdr = MozartDatabase.ExecuteReader(sSQL))
          {
            while (sdr.Read())
            {
              string sPwd = Password();
              string sNom = sdr["NSITNUE"].ToString().Replace("'", "''");
              using (SqlCommand cmd = new SqlCommand("api_sp_creationAccesWeb"))
              {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

                //  liste des paramètres
                cmd.Parameters["@iLogin"].Value = 0;
                cmd.Parameters["@iClient"].Value = miNumClient;
                cmd.Parameters["@vNom"].Value = sNom;
                cmd.Parameters["@vPwd"].Value = sPwd;
                cmd.Parameters["@cCat"].Value = "C";
                cmd.Parameters["@cDroit"].Value = "OUI";
                cmd.Parameters["@iValidation"].Value = 0;
                cmd.Parameters["@cTyp"].Value = "R";
                cmd.Parameters["@bCrt"].Value = false;
                cmd.Parameters["@bLogin"].Value = false;

                cmd.ExecuteNonQuery();

                //  récupération du numéro crée
                int iLogin = (int)cmd.Parameters[0].Value;
                MozartDatabase.ExecuteNonQuery($"EXEC api_sp_CreationLigneAccesweb  '{sNom}', '{sPwd} ', 'C', {miNumClient}, {sdr["NSITNUM"]}, '{cboDroit.Text} ', {txtValid.Text},'R', {iLogin}");

                // Suppression des droits de la personne
                MozartDatabase.ExecuteNonQuery($"DELETE TDROITWEB WHERE VUTILOG = '{sNom}' AND CUTICAT='C' AND NCLINUM = {miNumClient}");

                // insertion dans la table des droits avec copie du responsable
                sSQL = "INSERT INTO TDROITWEB (vutilog, CUTICAT, NCLINUM, nmenunum, cdroitval )" +
                      $" SELECT '{sdr["NSITNUE"].ToString().Replace("'", "''")}', 'C', NCLINUM, NMENUNUM, CDROITVAL FROM TDROITWEB WHERE VUTILOG = '-Responsable-' AND CUTICAT='P' AND NCLINUM = {miNumClient}";
                MozartDatabase.ExecuteNonQuery(sSQL);

                // Contrat client web
                sSQL = "insert into DroitContratClientWeb (NCLINUM, VUTILOG, NTYPECONTRAT, NACCNUM)"
                    + $" select {miNumClient}, '{sNom}', NTYPECONTRAT, NACCNUM FROM TUTI INNER JOIN TCONTRATCLI ON TCONTRATCLI.NCLINUM = TUTI.NUTINUM "
                    + $" WHERE NUTINUM = {miNumClient} AND VUTILOG NOT IN (select VUTILOG from DroitContratClientWeb where NCLINUM = {miNumClient})";
                MozartDatabase.ExecuteNonQuery(sSQL);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private string Password()
    {
      string ret = "";
      Random Rnd = new Random();
      string[] TabAlpha = new string[24] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
      ret += TabAlpha[Rnd.Next(23)];
      ret += TabAlpha[Rnd.Next(23)];
      ret += Rnd.Next(9).ToString();
      ret += TabAlpha[Rnd.Next(23)];
      ret += TabAlpha[Rnd.Next(23)];
      ret += Rnd.Next(9).ToString();
      return ret;
    }

    private void CmdPrixbyCont_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdPrixbyCont.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);

      new frmPrixClientContrat { miNumClient = miNumClient }.ShowDialog();
    }

    private void cmdEnvoiMail_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Attention, vous allez envoyer un mail contenant les identifiants Web à chaque responsable site !", Program.AppTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdEnvoiMail.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);
        MozartDatabase.ExecuteNonQuery($"exec api_sp_SendMailRespSiteClient {miNumClient}");
      }
    }

    private void chkGestNumero_CheckedChanged(object sender, EventArgs e)
    {
      cmdAnaGidtCli.Visible = chkGestNumero.Checked;
    }

    private void cmdCreateContEI_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdCreateContEI.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);
      new frmStarterContratEI(miNumClient, "0", "C").ShowDialog();
    }

    private void CmdModifContEI_Click(object sender, EventArgs e)
    {
      if (iIDPROCEI == 0)
      {
        MessageBox.Show("Il faut créer un contrat EI !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdModifContEI.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient, "VCLINOM:" + txtNom.Text);
      new frmStarterContratEI(miNumClient, iIDPROCEI, "M").ShowDialog();
    }

    private void cmdBudget_Click(object sender, EventArgs e)
    {
      new frmAdminBudget { miNumClient = (int)miNumClient }.ShowDialog();
    }

    private void cmdMAJCtPrev_Click(object sender, EventArgs e)
    {
      new frmGestContratPrev(miNumClient).ShowDialog();

      fillFrameContratPrev();
    }

    private void cmdAideTotSaisieManuelle_Click(object sender, EventArgs e)
    {
      string sChaine = "Montant du forfait préventif seul, de l'année en cours.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdAideRemonteeDI_Click(object sender, EventArgs e)
    {
      string sChaine = "Montant du forfait préventif seul (hors contrat 'FACTURATION'), remontant des DI créées, de l'année en cours.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdAideTotFact_Click(object sender, EventArgs e)
    {
      string sChaine = "Montant du forfait préventif seul (contrat 'FACTURATION' uniquement), remontant des DI créées, de l'année en cours.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdAideTotCur_Click(object sender, EventArgs e)
    {
      string sChaine = "Montant total du forfait curatif et/ou fourniture seul, si compris au contrat.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdAideImpaye_Click(object sender, EventArgs e)
    {
      string sChaine = $"Transmission d'un mail automatique regroupant les factures dont l'échéance sera atteinte 15 jours après " +
        $"l'enoi du mail. Un deuxième mail du même type sera transmis 3 jours avant la date d'échéance des factures. Les destinataires " +
        $"seront identifiés dans la liste des contacts du client via la sélection 'OUI' dans le champ 'Destinataire des relances impayées";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void RemplirListePrestation()
    {
      try
      {
        DataTable dtPrestation = new DataTable();
        ModuleData.LoadData(dtPrestation, $"SELECT VPRELIB, CPRECOD FROM TREF_PRE WHERE CPRECOD<>'K' AND LANGUE = '{MozartParams.Langue}' ORDER BY VPRELIB");

        lstPresta.Items.Clear();

        foreach (DataRow prestationRow in dtPrestation.Rows)
        {
          lstPresta.Items.Add(new ListPrestationItemData()
          {
            VPRELIB = prestationRow["VPRELIB"].ToString(),
            CPRECOD = Convert.ToChar(prestationRow["CPRECOD"].ToString().Substring(0, 1))
          });
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //  on coche toutes les prestations de la liste puis on décoche les interdites
    private void CocherLesPrestations()
    {
      try
      {
        DataTable dtDroitPresta = new DataTable();
        //  on coche toutes les prestations de la liste
        for (int i = 0; i < lstPresta.Items.Count; i++)
          lstPresta.SetItemChecked(i, true);

        // recherche des prestations non autorisées
        ModuleData.LoadData(dtDroitPresta, $"Select CPRECOD from TCLIPREST WHERE NCLINUM = {miNumClient}");

        //  parcours du recordset et de la listebox
        foreach (DataRow droitPrestaRow in dtDroitPresta.Rows)
        {
          for (int i = 0; i < lstPresta.Items.Count; i++)
          {
            ListPrestationItemData item = (ListPrestationItemData)lstPresta.Items[i];

            if (item.CPRECOD == Convert.ToChar(droitPrestaRow["CPRECOD"].ToString().Substring(0, 1)))
            {
              lstPresta.SetItemChecked(i, false);
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

    private void cmdPrestation_Click(object sender, EventArgs e)
    {
      RemplirListePrestation();
      CocherLesPrestations();
      apiGrpBoxPrestation.Top = 280;
      apiGrpBoxPrestation.Left = 100;
      apiGrpBoxPrestation.Visible = true;

    }

    private void cmdAnnulerPrest_Click(object sender, EventArgs e)
    {
      apiGrpBoxPrestation.Visible = false;
    }

    private void cmdValidePrest_Click(object sender, EventArgs e)
    {
      // on supprime toutes les données de la table prestation pour ce client
      MozartDatabase.ExecuteNonQuery($"delete from TCLIPREST WHERE NCLINUM = {miNumClient}");

      // parcours de la liste et insertion des prestations non cochées
      // c'est une table des restrictions
      for (int i = 0; i < lstPresta.Items.Count; i++)
      {
        if (lstPresta.GetItemChecked(i) == false)
        {
          ListPrestationItemData item = (ListPrestationItemData)lstPresta.Items[i];
          MozartDatabase.ExecuteNonQuery($"insert into TCLIPREST select {miNumClient} , '{item.CPRECOD}'");
        }

      }

      apiGrpBoxPrestation.Visible = false;
    }

    private void BtnAideHeureArrEXE_Click(object sender, EventArgs e)
    {
      string sChaine = $"Inscription des heures sur l'attachement du technicien hors action avec devis client.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnContrat_Click(object sender, EventArgs e)
    {
      new frmClientsContrats_Liste(miNumClient).ShowDialog();
    }

    private void cmdGMAOUsedHelp_Click(object sender, EventArgs e)
    {
      string sChaine = "Si la GMAO n'existe pas dans la liste, veuillez vous rapprocher des Méthodes ou de la Direction.";
      MessageBox.Show(sChaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}